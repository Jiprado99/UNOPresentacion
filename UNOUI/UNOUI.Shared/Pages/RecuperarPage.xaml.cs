using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class RecuperarPage : Page
    {
        public RecuperarPage()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<Palabra> Palabras { get; set; }

        private async void BtnRecuperar_Click(object sender, RoutedEventArgs e)
        {
            var response = await ApiService.RecuperarPalabraAsync();

            if (!response.IsSuccess)
            {
                var messageDialog = new MessageDialog(response.Message, "Aceptar");
                await messageDialog.ShowAsync();
                return;
            }

            var palabras = (Palabra[])response.Result;

            if (palabras == null)
            {
                new MessageDialog("Palabras es null", "Aceptar");
                return;
            }
        }
    }
}
