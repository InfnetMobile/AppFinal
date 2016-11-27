using Xamarin.Forms;

namespace AppFinalMITInfnet.Views
{
    public partial class ClientListPage : ContentPage
    {
        public ClientListPage()
        {
            InitializeComponent();
            this.customListView.ItemSelected += (sender, e) =>
            {
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}