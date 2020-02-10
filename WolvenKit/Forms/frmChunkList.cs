﻿using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmChunkList : DockContent, IThemedContent
    {
        private CR2WFile file;        
            
        public frmChunkList()
        {
            InitializeComponent();
            ApplyCustomTheme();
            //limitTB.Enabled = limitCB.Checked;
            treeListView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;

            treeListView.CanExpandGetter = delegate (object x) {
                return File.chunks.Any(_ => _.ParentChunkId - 1 == ((CR2WChunk)x).ChunkIndex);
            };
            treeListView.ChildrenGetter = delegate (object x) {
                return File.chunks.Where(_ => _.ParentChunkId - 1 == ((CR2WChunk)x).ChunkIndex);
            };
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                UpdateList();
            }
        }

        public event EventHandler<SelectChunkArgs> OnSelectChunk;

        public void UpdateList(string keyword = "")
        {
            var limit = -1;
            //if(limitCB.Checked)
            //{
            //    int.TryParse(limitTB.Text,out limit);
            //}
            if (File == null)
                return;
            if(!string.IsNullOrEmpty(keyword))
            {
                if (limit != -1)
                {
                    //treeListView.Objects = File.chunks.Where(x => x.Name.ToUpper().Contains(toolStripSearchBox.Text.ToUpper())).Take(limit);
                }
                else
                {
                    this.treeListView.ModelFilter = TextMatchFilter.Contains(treeListView, toolStripSearchBox.Text.ToUpper());
                }
            }
            else
            {
                treeListView.ModelFilter = null;
                treeListView.Roots = File.chunks.Where(_ => _.Parent == null).ToList();
            }
            if (treeListView.Items.Count < 1000)
            {
                treeListView.ExpandAll();
            }
            
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (OnSelectChunk != null && (CR2WChunk)treeListView.SelectedObject != null)
            {
                OnSelectChunk(this, new SelectChunkArgs { Chunk = (CR2WChunk)treeListView.SelectedObject });
            }
        }

        private void addChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmAddChunk();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var chunk = File.CreateChunk(dlg.ChunkType);
                    UpdateList();

                    if (OnSelectChunk != null && chunk != null)
                    {
                        OnSelectChunk(this, new SelectChunkArgs {Chunk = chunk});
                    }
                }
                catch (InvalidChunkTypeException ex)
                {
                    MessageBox.Show(ex.Message, "Error adding chunk.");
                }
            }
        }

        private void deleteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObjects.Count == 0)
                return;

            if (MessageBox.Show("Are you sure you want to delete the selected chunk(s)? \n\n NOTE: Any pointers or handles to these chunks will NOT be deleted.","Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var selected = treeListView.SelectedObjects;
                foreach (var obj in selected)
                {
                    File.RemoveChunk((CR2WChunk) obj);
                }

                UpdateList();
            }
        }

        private void copyChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyChunks();
        }

        public void CopyChunks()
        {
            Clipboard.Clear();
            var chunks = treeListView.SelectedObjects.Cast<CR2WChunk>().ToList();
            CopyController.ChunkList = chunks;
            pasteChunkToolStripMenuItem.Enabled = true;
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteChunks();
        }

        public void PasteChunks()
        {
            var copiedchunks = CopyController.ChunkList;
            if (copiedchunks != null && copiedchunks.Count > 0)
            {
                foreach (var chunk in copiedchunks)
                {
                    try
                    {
                        var pastedchunk = CR2WCopyAction.CopyChunk(chunk, chunk.CR2WOwner);
                        OnSelectChunk?.Invoke(this, new SelectChunkArgs { Chunk = pastedchunk });
                        MainController.Get().ProjectStatus = "Chunk copied";
                        UpdateList();
                    }
                    catch (InvalidChunkTypeException ex)
                    {
                        MessageBox.Show(ex.Message, @"Error adding chunk.");
                    }
                }
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            UpdateList(toolStripSearchBox.Text);
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            toolStripSearchBox.Clear();
            UpdateList();
        }

        private void limitCB_CheckStateChanged(object sender, EventArgs e)
        {
            //limitTB.Enabled = limitCB.Checked;
        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            //if(e.KeyValue == (int)Keys.Enter)
                UpdateList(toolStripSearchBox.Text);
        }

        private void listView_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            MainController.Get().ProjectUnsaved = true;
        }
        
        public void ApplyCustomTheme()
        {
            var theme = MainController.Get().GetTheme();
            MainController.Get().ToolStripExtender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            this.treeListView.BackColor = theme.ColorPalette.TabButtonSelectedInactivePressed.Background; 
            toolStripSearchBox.BackColor = theme.ColorPalette.ToolWindowCaptionButtonInactiveHovered.Background; 

            this.treeListView.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.OverflowButtonHovered.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                }
            };
            this.treeListView.HeaderFormatStyle = hfs;
            treeListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;
            
            
        }
    }
}