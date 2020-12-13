using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    public partial class CovidStats
    {
        public CovidStats()
        {
            InitializeComponent();
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            const string quote = "\""; 
            htmlSource.Html = @"<html><body>" +
            "<h1></h1>" +
              "<p></p>" +
"<script src=" + quote + "https://apps.elfsight.com/p/platform.js" + quote +
            "defer></script>" +
"<div class=" + quote+ "elfsight-app-ecb58423-a880-4350-aa92-bf49c73866be" + quote + "></div>" +  
              "</body></html>";
            browser.Source = htmlSource;
            BrowserGrid.Children.Add(browser);
        }
    }
}