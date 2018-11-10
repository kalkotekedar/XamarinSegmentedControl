using System.Collections.Generic;
using Xamarin.Forms;

namespace SegmentedControl.Controls
{
    #region Segmented Control Text View
    public class SegmentedControlOption : View
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create<SegmentedControlOption, string>(p => p.Text, "");

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty IsCheckedProperty =
            BindableProperty.Create(
               propertyName: "IsChecked",
               returnType: typeof(bool),
               defaultValue: true,
               declaringType: typeof(SegmentedControlOption));

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public SegmentedControlOption()
        {
        }
    }
    #endregion

    public class SCControl : View, IViewContainer<SegmentedControlOption>
    {
        public IList<SegmentedControlOption> Children { get; }

        public SCControl()
        {
            Children = new List<SegmentedControlOption>();
        }

        public event ValueChangedEventHandler ValueChanged;
        public delegate void ValueChangedEventHandler(object sender, string selectedValue);

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            foreach (var child in Children)
                child.BindingContext = this.BindingContext;
        }

        private string selectedValue;
        public string SelectedValue
        {
            get { return selectedValue; }
            set
            {
                var existingValue = selectedValue;
                selectedValue = value;
                if (ValueChanged != null && selectedValue != existingValue)
                    ValueChanged(this, value);
            }
        }
    }
}