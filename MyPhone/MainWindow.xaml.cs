using GoodTimeStudio.MyPhone.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MUXC = Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GoodTimeStudio.MyPhone
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();

            this.ExtendsContentIntoTitleBar = true;
            //this.SetTitleBar(AppTitleBar);

            ViewModel = new MainPageViewModel();
        }

        private void NavigationViewControl_SelectionChanged(MUXC.NavigationView sender, MUXC.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

            }
            else
            {
                NavigationMenu item = (NavigationMenu)args.SelectedItem; //TODO: better MVVM
                //switch (item.Name)
                //{
                //    case "Call":
                //        contentFrame.Navigate(typeof(CallPage));
                //        break;
                //    case "Message":
                //        contentFrame.Navigate(typeof(MessagePage));
                //        break;
                //    case "Debug":
                //        contentFrame.Navigate(typeof(TestPage));
                //        break;
                //}
            }

        }
    }
}
