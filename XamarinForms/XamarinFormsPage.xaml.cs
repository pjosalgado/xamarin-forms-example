using Xamarin.Forms;

namespace XamarinForms
{
    public partial class XamarinFormsPage : ContentPage
    {
        
        public XamarinFormsPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }

    }
}
