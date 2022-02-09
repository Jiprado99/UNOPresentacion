using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UNOUI.Helpers;
using UNOUI.Helpers.Interfaces;
using UNOUI.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class AgregarPage : Page
    {
        private IApiService ApiService => AFacHelper.Container.Resolve<IApiService>();

        public AgregarPage()
        {
            this.InitializeComponent();
        }

        private async void BtnAgregar_Tapped(object sender, RoutedEventArgs e)
        {
            SendPalabra();
        }

        private async void TxtPalabra_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
                SendPalabra();
        }

        private async void SendPalabra()
        {
            if (!string.IsNullOrEmpty(TxtPalabra.Text))
            {
                string palabra = TxtPalabra.Text;
                TxtPalabra.Text = "";
                TxtPalabra.Focus(FocusState.Programmatic);
                var response = await ApiService.PostAsync<string, List<Palabra>>("Agregar", palabra);

                TxtError.Visibility = Visibility.Collapsed;

                if (!response.IsSuccess)
                {
                    ErrorMessage(response.Message);
                    return;
                }
            }
            else
                TxtError.Text = "Ingrese una palabra.";
        }

        private void ErrorMessage(string message)
        {
            TxtError.Text = message;
            TxtError.Visibility = Visibility.Visible;
        }
    }
}