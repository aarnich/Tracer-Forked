using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    public partial class MapView
    {
        public MapView()
        {
            InitializeComponent();

            HtmlWebViewSource htmlSource = new HtmlWebViewSource();
            StringBuilder htmlStr = new StringBuilder("");
            htmlStr.Append("<html>");
            htmlStr.Append("<body>");
            htmlStr.Append(@"<div class=""bingwidget"" data-type=""covid19"" data-market=""en-us"" data-language=""en-us""></div>");
            htmlStr.Append(@"<script src =""https://www.bing.com/widget/bootstrap.answer.js"" async =""""></script>");
            htmlStr.Append("</body>");
            htmlStr.Append("</html");
            htmlSource.Html = htmlStr.ToString();
            browser.Source = htmlSource;
        }
    }
}