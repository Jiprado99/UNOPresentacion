﻿using System;
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

        private async void BtnRecuperarPalabra_Tapped(object sender, RoutedEventArgs e)
        {
            var response = await ApiService.RecuperarPalabraAsync();
            //response.ContinueWith(t => Presentar(response.Result));
            Presentar(response);
        }

        private void Presentar(Response response)
        {
            TxtError.Visibility = Visibility.Collapsed;
            if (!response.IsSuccess)
            {
                ErrorMessage(response.Message);
                //new MessageDialog(response.Message, "Error").ShowAsync();
                return;
            }

            var palabras = (Palabra[])response.Result;

            if (palabras == null)
            {
                ErrorMessage(response.Message);
                //new MessageDialog("No se han podido encontrar palabras.", "Error").ShowAsync();
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
