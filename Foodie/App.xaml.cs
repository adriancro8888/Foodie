using System.Collections.Generic;

using Xamarin.Forms;
using Foodie.Views;

namespace Foodie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.MainPage = new NavigationPage(new EditRecipePage());

        }


    }
}
