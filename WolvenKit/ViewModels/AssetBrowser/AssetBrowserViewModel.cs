﻿using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CP77.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.ViewModels.AssetBrowser
{
    class AssetBrowserViewModel : ViewModelBase
    {
        public GameFileTreeNode CurrentNode { get; set; } = new GameFileTreeNode();
        public List<AssetBrowserData> CurrentNodeFiles { get; set; } = new List<AssetBrowserData>();
        public GameFileTreeNode RootNode { get; set; }
        public List<IGameFile> SelectedFiles { get; set; }
        public List<IGameArchiveManager> Managers { get; set; }
        public List<string> Extensions { get; set; }
        public string SelectedExtension { get; set; }
        public List<string> Classes { get; set; }
        public string SelectedClass { get; set; }

        public AssetBrowserViewModel(List<IGameArchiveManager> managers, List<string> AvaliableClasses)
        {
            SelectedFiles = new List<IGameFile>();
            Managers = managers;

            this.CurrentNode = new GameFileTreeNode(EArchiveType.ANY)
            {
                Name = "Depot"
            };
            foreach (var mngr in managers)
            {
                mngr.RootNode.Parent = this.CurrentNode;
                this.CurrentNode.Directories.Add(mngr.TypeName.ToString(), mngr.RootNode);
            }
            this.CurrentNodeFiles = this.CurrentNode.ToAssetBrowserData();
            this.RootNode = this.CurrentNode;
            this.Extensions = managers.SelectMany(x => x.Extensions).ToList();
            this.Classes = AvaliableClasses;
        }
    }
}
