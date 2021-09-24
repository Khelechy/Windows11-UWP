using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void menuButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
            menuPopup.IsOpen = !menuPopup.IsOpen;
            if (menuPopup2.IsOpen)
            {
                menuPopup2.IsOpen = false;
            }

        }

        private void Frame_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPopup.IsOpen = !menuPopup.IsOpen;
            menuPopup2.IsOpen = !menuPopup2.IsOpen;
        }
    }
}
