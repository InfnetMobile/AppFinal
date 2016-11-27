using Xamarin.Forms;

namespace AppFinalMITInfnet
{
    public class CustomLoginEntry : Entry
    {
		private static readonly BindableProperty borderColorProperty =
			BindableProperty.Create<CustomLoginEntry, Color>(p => p.BorderColor, Color.White);

		public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create<CustomLoginEntry, double>(p => p.FontSize, Font.Default.FontSize);

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create<CustomLoginEntry, Color>(p => p.PlaceholderColor, Color.Silver);

        public Color PlaceholderColor
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

		public static BindableProperty BorderColorProperty
		{
			get
			{
				return borderColorProperty;
			}
		}
	}
}
