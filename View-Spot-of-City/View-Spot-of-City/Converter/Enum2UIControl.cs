﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View_Spot_of_City.Converter
{
    public class Enum2UIControl : IValueConverter
    {
        /// <summary>
        /// 主控件
        /// </summary>
        public enum MainControls : int
        {
            ArcGISSceneView = 0,
            ArcGISMapView = 1
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null) { return null; }
            try { return (int)value == System.Convert.ToInt32((string)parameter) ? Visibility.Visible : Visibility.Collapsed; }
            catch { return null; }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
