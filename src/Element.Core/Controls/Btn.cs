using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Element.Core.Controls
{
    public class Btn : Button
    {
        static Btn()
        {
            // Console.WriteLine("先");
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
        }

        //public Btn()
        //{
        //    Console.WriteLine("后");
        //}


        /*
         
        System.Windows.Media.CombinedGeometry
System.Windows.Media.EllipseGeometry
System.Windows.Media.GeometryGroup
System.Windows.Media.LineGeometry
System.Windows.Media.PathGeometry
System.Windows.Media.RectangleGeometry
System.Windows.Media.StreamGeometry

         */

        //public Geometry Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Bindable(true)]
        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(Geometry), typeof(Btn));

        /// <summary>
        /// 按钮圆角
        /// </summary>
        [Bindable(true)]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // PropertyMetadata FrameworkPropertyMetadata
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(Btn), 
                new PropertyMetadata(new CornerRadius(4)));





    }
}
