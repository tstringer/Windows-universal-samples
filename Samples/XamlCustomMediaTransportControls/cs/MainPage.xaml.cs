using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CustomMediaTransportControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //This following line is setting the source for the MediaElement
            this.MainME.Source = new System.Uri("https://sec.ch9.ms/ch9/ad03/33a90710-0d66-4c48-8f7f-db974771ad03/WSFLArchitectureDeepuThomas_high.mp4");
        }

        private void ChangeToEnglish_Click(object sender, RoutedEventArgs e)
        {
            Frame.CacheSize = 0;
            ApplicationLanguages.PrimaryLanguageOverride = "en";
            //MainME.TransportControls.Language = "en";
            Frame.Navigate(this.GetType());
        }

        private void ChangeToSpanish_Click(object sender, RoutedEventArgs e)
        {
            Frame.CacheSize = 0;
            ApplicationLanguages.PrimaryLanguageOverride = "es";
            //MainME.TransportControls.Language = "es";
            Frame.Navigate(this.GetType());
        }
    }
}
