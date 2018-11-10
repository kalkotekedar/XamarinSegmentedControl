using Prism.Navigation;

namespace SegmentedControl.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Segmented Control";
        }

        public bool _optionOne;
        public bool OptionOne
        {
            get { return _optionOne; }
            set { SetProperty(ref _optionOne, value); }
        }

        public bool _optionTwo;
        public bool OptionTwo
        {
            get { return _optionTwo; }
            set { SetProperty(ref _optionTwo, value); }
        }

        public bool _optionThree;
        public bool OptionThree
        {
            get { return _optionThree; }
            set { SetProperty(ref _optionThree, value); }
        }

        public bool _optionMale;
        public bool OptionMale
        {
            get { return _optionMale; }
            set { SetProperty(ref _optionMale, value); }
        }

        public bool _optionFemale;
        public bool OptionFemale
        {
            get { return _optionFemale; }
            set { SetProperty(ref _optionFemale, value); }
        }
    }
}