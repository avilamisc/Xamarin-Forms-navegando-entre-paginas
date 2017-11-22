using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntrePages.ViewModels;
using Xamarin.Forms;

namespace EntrePages
{
    public partial class Primera : ContentPage
    {        
        public Primera()
        {
            InitializeComponent();
            this.BindingContext = new PrimeraViewModel(this.Navigation);
        }

        
    }
}
