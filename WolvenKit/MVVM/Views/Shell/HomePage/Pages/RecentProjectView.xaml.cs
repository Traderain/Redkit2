
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class RecentProjectView
    {
        public RecentProjectView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Recent Projects");
            }

        }
    }
}