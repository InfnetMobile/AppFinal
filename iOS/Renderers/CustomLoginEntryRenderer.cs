using System;
using AppFinalMITInfnet;
using AppFinalMITInfnet.iOS;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomLoginEntry), typeof(CustomLoginEntryRenderer))]
namespace AppFinalMITInfnet.iOS
{
    public class CustomLoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (Element as CustomLoginEntry);
                DrawBorder(view);
            }

            if (e.OldElement != null)
            {

            }
        }

        void DrawBorder(CustomLoginEntry view)
        {
            var borderLayer = new CALayer();
            borderLayer.MasksToBounds = true;
            borderLayer.Frame = new CGRect(0f, Frame.Height / 2, UIScreen.MainScreen.Bounds.Width - 40f, 1.0f);
            borderLayer.BorderColor = view.BorderColor.ToCGColor();
            borderLayer.BorderWidth = 1.0f;

            Control.Layer.AddSublayer(borderLayer);
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
