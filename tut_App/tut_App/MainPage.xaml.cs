using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tut_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Vacationbtn_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TimePermissionRequest());
        }
    }
}
