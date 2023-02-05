using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Element.Core.Controls
{
    public class BorderElement
    {
        #region CornerRadius  x:Key="el-border-radius-base"

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(BorderElement), 
            new PropertyMetadata(default(CornerRadius)));

        public static void SetCornerRadius(DependencyObject element, CornerRadius value)
            => element.SetValue(CornerRadiusProperty, value);

        public static CornerRadius GetCornerRadius(DependencyObject element) => 
            (CornerRadius)element.GetValue(CornerRadiusProperty);

        #endregion


        #region MyRegion

        #endregion
    }
}
