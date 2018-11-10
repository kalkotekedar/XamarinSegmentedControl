using Xamarin.Forms;
using SegmentedControl.iOS;
using SegmentedControl.Controls;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(SCControl), typeof(SCControlRendereriOS))]
namespace SegmentedControl.iOS
{
    public class SCControlRendereriOS : ViewRenderer<SCControl, UISegmentedControl>
    {
        public SCControlRendereriOS()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SCControl> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var segmentedControl = new UISegmentedControl();

                for (var i = 0; i < e.NewElement.Children.Count; i++)
                {
                    var o = e.NewElement.Children[i];
                    if (!o.IsVisible)
                        continue;

                    segmentedControl.InsertSegment(o.Text, i, false);
                    if (o.IsChecked)
                        segmentedControl.SelectedSegment = i;
                }

                segmentedControl.ValueChanged += (sender, eventArgs) =>
                {
                    e.NewElement.SelectedValue = segmentedControl.TitleAt(segmentedControl.SelectedSegment);
                };

                SetNativeControl(segmentedControl);
            }
        }
    }
}