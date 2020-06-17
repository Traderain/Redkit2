﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CColor : CVariable
    {
        [Browsable(false)]
        [RED] public CUInt8 Red { get; set; }
        [Browsable(false)]
        [RED] public CUInt8 Green { get; set; }
        [Browsable(false)]
        [RED] public CUInt8 Blue { get; set; }
        [Browsable(false)]
        [RED] public CUInt8 Alpha { get; set; }


        public CColor(CR2WFile cr2w) : base(cr2w)
        {
            Red = new CUInt8(cr2w);
            Green = new CUInt8(cr2w);
            Blue = new CUInt8(cr2w);
            Alpha = new CUInt8(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public Color Color
        {
            get { return Color.FromArgb(Alpha.val, Red.val, Green.val, Blue.val); }
            set
            {
                Red.val = value.R;
                Green.val = value.G;
                Blue.val = value.B;
                Alpha.val = value.A;
            }
        }

        public override CVariable SetValue(object val)
        {
            if (val is Color)
            {
                Color = (Color)val;
            }

            return this;
        }

        public override Control GetEditor()
        {
            var panel = new Panel();
            panel.BackColor = Color.FromArgb(Red.val, Green.val, Blue.val);
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            dlg.Color = Color;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Red.val = dlg.Color.R;
                Green.val = dlg.Color.G;
                Blue.val = dlg.Color.B;

                ((Panel)sender).BackColor = dlg.Color;
            }
        }

        public override CVariable Create(CR2WFile cr2w) => new CColor(cr2w);
    }
}