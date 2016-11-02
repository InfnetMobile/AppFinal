using System;

using Xamarin.Forms;
using artina = UXDivers.Artina.Shared;

namespace AppFinalMITInfnet
{
    public class AppConstants
    {
        public static Color DefaultBackgroundColor = Color.FromHex("#52649a");
        public static Color LoginButtonColor = Color.FromHex("#54b720");
        public static Color TranslucidBlack = Color.FromHex("#000000");

        public static Style FontIcon = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter
                {
                    Property = Label.FontFamilyProperty,
                    Value = artina.FontAwesome.FontName
                }
            }
        };

        public static Style Avatar = new Style(typeof(artina.CircleImage))
        {
            Setters =
            {
                new Setter
                {
                    Property = VisualElement.WidthRequestProperty,
                    Value = 50
                },
                new Setter
                {
                    Property = VisualElement.HeightRequestProperty,
                    Value = 50
                },
                new Setter
                {
                    Property = artina.CircleImage.BorderThicknessProperty,
                    Value = 3
                },
                new Setter
                {
                    Property = artina.CircleImage.BorderColorProperty,
                    Value = DefaultBackgroundColor
                }
            }
        };

        public static Style BrandNameOrnamentStyle = new Style(typeof(BoxView))
        {
            Setters =
            {
                new Setter
                {
                    Property = VisualElement.HeightRequestProperty,
                    Value = 4
                },
                new Setter
                {
                    Property = VisualElement.WidthRequestProperty,
                    Value = 40
                },
                new Setter
                {
                    Property = View.VerticalOptionsProperty,
                    Value = "End"
                },
                new Setter
                {
                    Property = View.HorizontalOptionsProperty,
                    Value = "Start"
                },
                new Setter
                {
                    Property = VisualElement.BackgroundColorProperty,
                    Value = DefaultBackgroundColor
                }
            }
        };

        public static Style ToolbarStyle = new Style(typeof(Grid))
        {
            Setters =
            {
                new Setter
                {
                    Property = VisualElement.HeightRequestProperty,
                    Value = 60
                },
                new Setter
                {
                    Property = Grid.ColumnSpacingProperty,
                    Value = 0
                }
            }
        };
    }
}
