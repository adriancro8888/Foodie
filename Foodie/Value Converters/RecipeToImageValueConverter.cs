using System;
using System.Globalization;
using Xamarin.Forms;

namespace Foodie
{
    public class RecipeToImageValueConverter : IValueConverter
    {
        public string Assembly { get; set; }
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;

            if (string.IsNullOrEmpty(source))
                return null;
            var imagePath = $"{Assembly}.{source}";
            var image = ImageSource.FromResource(imagePath);

            return ImageSource.FromResource(imagePath);


        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
