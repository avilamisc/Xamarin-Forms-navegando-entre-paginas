using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntrePages.ViewModels
{
    public class TerceraViewModel
    {
        public Command ClickedCommand { get; set; }
        public INavigation Navigation { get; set; }
        public TerceraViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            ClickedCommand = new Command(async () => await ALaSiguiente());
        }

        public async Task ALaSiguiente()
        {
            await Navigation.PopToRootAsync();
        }
    }
}
