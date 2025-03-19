using CalculationModule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculationModule.View
{
    /// <summary>
    /// Логика взаимодействия для PointDetailsWindow.xaml
    /// </summary>
    public partial class PointDetailsWindow : Window
    {
        public PointDetailsWindow(MapPoint point)
        {
            InitializeComponent();

            NameTextBox.Text = point.Name;
            LatitudeTextBox.Text = point.Latitude.ToString();
            LongitudeTextBox.Text = point.Longitude.ToString();
        }
    }
}
