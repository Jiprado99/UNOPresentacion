using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UNOUI.Helpers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UNOUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(RecuperarPage));
        }

        private void NVIAgregar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AgregarPage));
        }

        private void NVIConsultar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(RecuperarPage));
        }

        private async void NVIEliminar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await ApiService.DeleteAsync();
        }
    }
}
