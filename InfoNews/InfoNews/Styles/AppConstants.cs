using System;
using Xamarin.Forms;

namespace InfoNews
{
	public class AppConstants
	{
		public static Style ButtonInicial = new Style(typeof(Button))
		{
			Setters =
			{
				new Setter
				{
					Property = View.VerticalOptionsProperty,
					Value = "Center"
				},
				new Setter
				{
					Property = View.HorizontalOptionsProperty,
					Value = "Center"
				},
				new Setter
				{
					Property = Button.BorderWidthProperty,
					Value = 0
				},
				new Setter
				{
					Property = VisualElement.WidthRequestProperty,
					Value = 200
				},
				new Setter
				{
					Property = VisualElement.HeightRequestProperty,
					Value = 50
				},
				new Setter
				{
					Property = View.MarginProperty,
					Value = 10
				},
				new Setter
				{
					Property = Button.TextColorProperty,
					Value = "White"
				},
				new Setter
				{
					Property = Button.FontAttributesProperty,
					Value = "Bold"
				},
				new Setter
				{
					Property = VisualElement.BackgroundColorProperty,
					Value = "Maroon"
				}
			}
		};

		public static Style LabelInfo = new Style(typeof(Label))
		{
			Setters =
			{
				new Setter
				{
					Property = Label.FontSizeProperty,
					Value = 14
				},
				new Setter
				{
					Property = Label.FontFamilyProperty,
					Value = "HelveticaNeue-Medium"
				}
			}
		};

		public static Style LabelInfoMarron = new Style(typeof(Label))
		{
			Setters =
			{
				new Setter
				{
					Property = Label.FontSizeProperty,
					Value = 14
				},
				new Setter
				{
					Property = Label.FontFamilyProperty,
					Value = "HelveticaNeue-Medium"
				},

				new Setter
				{
					Property = Label.TextColorProperty,
					Value = "Maroon"
				}
			}
		};

		public static Style LabelInfoForm = new Style(typeof(Label))
		{
			Setters =
			{
				new Setter
				{
					Property = Label.HorizontalTextAlignmentProperty,
					Value = "Center"
				}
			}
		};
	}
}
