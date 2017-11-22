using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntrePages.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntrePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Segunda : ContentPage
    {
        public Segunda()
        {
            InitializeComponent();
            this.BindingContext = new SegundaViewModel(this.Navigation);
        }

       
    }
}