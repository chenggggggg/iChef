using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iChef
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishView : ContentPage
    {
        public DishView()
        {
            InitializeComponent();

            LoadDishInformation();
        }

        public void LoadDishInformation()
        {

        }
    }
}