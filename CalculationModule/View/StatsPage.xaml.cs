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
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WPF;
using SkiaSharp;

namespace CalculationModule.View
{
    /// <summary>
    /// Логика взаимодействия для StatsPage.xaml
    /// </summary>
    public partial class StatsPage : Window
    {
        public StatsPage()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            var values = new List<double> { 3.5, 7.8, 5.2, 9.1, 6.4 }; // Примерные данные

            var series = new LineSeries<double>
            {
                Values = values,
                Fill = null, // Прозрачная заливка
                Stroke = new SolidColorPaint(SKColors.Blue), // Синий цвет линии
                GeometrySize = 10, // Размер точек на линии
                GeometryStroke = new SolidColorPaint(SKColors.Red) // Цвет точек на линии
            };

            StatisticsChart.Series = new ISeries[] { series };
            StatisticsChart.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = new List<string> { "Янв", "Фев", "Мар", "Апр", "Май" },
                    Name = "Месяц",
                    NamePaint = new SolidColorPaint(SKColors.Black), // Цвет подписей оси X
                    LabelsPaint = new SolidColorPaint(SKColors.Gray), // Цвет текста меток оси X
                    TextSize = 20 // Размер текста меток
                }
            };
            StatisticsChart.YAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => value.ToString("F1"),
                    Name = "Значение",
                    NamePaint = new SolidColorPaint(SKColors.Black), // Цвет подписей оси Y
                    LabelsPaint = new SolidColorPaint(SKColors.Gray), // Цвет текста меток оси Y
                    TextSize = 20 // Размер текста меток
                }
            };
        }
    }
}
