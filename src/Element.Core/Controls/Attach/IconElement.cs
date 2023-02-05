using System.Windows;
using System.Windows.Media;

namespace Element.Core.Controls
{
    public class IconElement
    {
        #region Icon 

        public static readonly DependencyProperty GeometryProperty = 
            DependencyProperty.RegisterAttached("Geometry", typeof(Geometry), typeof(IconElement), new PropertyMetadata(default(Geometry)));

        public static void SetGeometry(DependencyObject element, Geometry value)
            => element.SetValue(GeometryProperty, value);

        public static Geometry GetGeometry(DependencyObject element)
            => (Geometry)element.GetValue(GeometryProperty);
        #endregion

        // Side Length

        #region Length  Side Length

        public static readonly DependencyProperty LengthProperty =
            DependencyProperty.RegisterAttached("Length", typeof(double), typeof(IconElement), new PropertyMetadata(double.NaN));

        public static void SetLength(DependencyObject element, double value)
            => element.SetValue(LengthProperty, value);

        public static double GetLength(DependencyObject element)
            => (double)element.GetValue(LengthProperty);

        #endregion
    }

}
