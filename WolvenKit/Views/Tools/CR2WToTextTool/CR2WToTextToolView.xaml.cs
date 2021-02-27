﻿
namespace WolvenKit.Views.CR2WToTextTool
{
    public partial class CR2WToTextToolView
    {
        public CR2WToTextToolView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("CR2W To Text Tool");
            }
        }
    }
}
