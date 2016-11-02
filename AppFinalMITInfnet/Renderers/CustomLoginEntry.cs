using Xamarin.Forms;

namespace AppFinalMITInfnet
{
    public class CustomLoginEntry : Entry
    {
        public static readonly BindableProperty BorderColorProperty =
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
    }
}
