using AppFinalMITInfnet;
using AppFinalMITInfnet.iOS;
using CoreGraphics;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomListViewSeparatorRenderer), typeof(CustomListViewRenderer))]
namespace AppFinalMITInfnet.iOS
{
    public class CustomListViewRenderer: ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
            }

            if (e.NewElement != null)
            {
                var EmptyView = new UIView(new CGRect()) { BackgroundColor = UIColor.Clear };
                Control.TableFooterView = EmptyView;
            }
        }
    }
}
