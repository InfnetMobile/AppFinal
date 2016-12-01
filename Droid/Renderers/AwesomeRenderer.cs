using Android.Graphics;
using Android.Widget;
using AppFinalMITInfnet.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(AwesomeRenderer))]
namespace AppFinalMITInfnet.Droid
{
	public class AwesomeRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			var label = (TextView)Control;

			var text = label.Text;

			if (string.IsNullOrEmpty(text) || text.Length > 1 || text[0] < 0xf000)
			{
				return;
			}

			var font = Typeface.CreateFromAsset(Context.ApplicationContext.Assets, "fontawesome-webfont.ttf");
			label.Typeface = font;
		}
	}
}