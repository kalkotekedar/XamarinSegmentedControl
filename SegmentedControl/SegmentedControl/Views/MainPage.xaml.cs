using SegmentedControl.ViewModels;
using Xamarin.Forms;

namespace SegmentedControl.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel ViewModel { get; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = (MainPageViewModel)BindingContext;
        }

        private void SegmentedValueChanged(object sender, string selectedValue)
        {
            if (!string.IsNullOrEmpty(selectedValue))
            {
                if (selectedValue.Equals("option_one"))
                {
                    ViewModel.OptionOne = true;
                    ViewModel.OptionTwo = ViewModel.OptionThree = false;
                }
                else if (selectedValue.Equals("option_two"))
                {
                    ViewModel.OptionTwo = true;
                    ViewModel.OptionOne = ViewModel.OptionThree = false;
                }
                else if (selectedValue.Equals("option_three"))
                {
                    ViewModel.OptionThree = true;
                    ViewModel.OptionTwo = ViewModel.OptionOne = false;
                }
                else if (selectedValue.Equals("option_male"))
                {
                    ViewModel.OptionMale = true;
                    ViewModel.OptionFemale = false;
                }
                else if (selectedValue.Equals("option_female"))
                {
                    ViewModel.OptionFemale = true;
                    ViewModel.OptionMale = false;
                }
            }
        }
    }
}