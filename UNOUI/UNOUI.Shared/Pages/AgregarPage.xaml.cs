using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UNOUI.Helpers;
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
        public AgregarPage()
        {
            this.InitializeComponent();
        }

        private async void BtnAgregar_Tapped(object sender, RoutedEventArgs e)
        {
            string palabra = TxtPalabra.Text;
            TxtPalabra.Text = "";
            TxtPalabra.Focus(FocusState.Programmatic);
            var response = await ApiService.PostAsync("Palabras", palabra);
        }

        private void IsSucces(Response response)
        {
            if (!response.IsSuccess)
            {
                var messageDialog = new MessageDialog(response.Message, "Error");
                messageDialog.ShowAsync();
                return;
            }
        }
    }
}
