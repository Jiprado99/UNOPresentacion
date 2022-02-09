using Autofac;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class RecuperarPage : Page
    {
        private IApiService ApiService => AFacHelper.Container.Resolve<IApiService>();

        public RecuperarPage()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<Palabra> Palabras { get; set; }

        private async void BtnRecuperarPalabra_Tapped(object sender, RoutedEventArgs e)
        {
            var response = await ApiService.RecuperarPalabraAsync();
            //response.ContinueWith(t => Presentar(response.Result));
            Presentar(response);
        }

        private async void BtnRecuperarLetra_Tapped(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxbLetra.Text))
            {
                char letra = Convert.ToChar(TxbLetra.Text);
                if (letra >= 'a' && letra <= 'z' || letra >= 'A' && letra <= 'Z' || letra == 'Ñ' || letra == 'ñ')
                {
                    var response = await ApiService.RecuperarLetraAsync(char.ToUpper(letra));
                    Presentar(response);
                }
                else
                    ErrorMessage("Ingrese una letra válida");
            }
            else
            ErrorMessage("Ingrese una Letra");
        }

        private void Presentar(Response response)
        {
            TxtError.Visibility = Visibility.Collapsed;
            if (!response.IsSuccess)
            {
                ErrorMessage(response.Message);
                return;
            }

            var palabras = (Palabra[])response.Result;

            if (palabras == null)
            {
                ErrorMessage(response.Message);
                return;
            }

            Palabras = new ObservableCollection<Palabra>(palabras);
            RefreshList();
        }

        private void RefreshList()
        {
            LtvPalabras.ItemsSource = null;
            LtvPalabras.Items.Clear();
            LtvPalabras.ItemsSource = Palabras;
        }

        private void ErrorMessage(string message)
        {
            TxtError.Text = message;
            TxtError.Visibility = Visibility.Visible;
        }
    }
}