using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace tut_App
{
    public partial class VacationApprovalPage : ContentPage
    {

        public VacationApprovalPage()
        {
            InitializeComponent();
            this.Appearing += VacationApprovalPage_Appearing;
        }

        private void VacationApprovalPage_Appearing(object sender, EventArgs e)
        {
            //VacationPicker.Items.Add("vac1");
            // VacationPicker.Items.Add("vac2");
            // VacationPicker.Items.Add("vac3");

            //  lstView.ItemsSource = Customers.GetAllCustomers();


            IndustryTypePicker1.Items.Add("vac1");
            IndustryTypePicker1.Items.Add("vac2");
            IndustryTypePicker1.Items.Add("vac3");


        }
    }
}
