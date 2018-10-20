using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploDataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            areaBrowser.Source = url.Text;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            areaBrowser.GoBack();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            areaBrowser.GoForward();
        }
    }
}
