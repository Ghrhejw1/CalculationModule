using GMap.NET.MapProviders;
using GMap.NET;
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
    /// Логика взаимодействия для MapPage.xaml
    /// </summary>
    public partial class MapPage : UserControl
    {
        public MapPage()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void InitializeMap()
        {
            // Настройки карты
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            MapControl.MapProvider = GMapProviders.GoogleMap;
            MapControl.MinZoom = 2;
            MapControl.MaxZoom = 18;
            MapControl.Zoom = 10;
            MapControl.Position = new PointLatLng(67.567, 33.399); // Координаты Аппатитов
            MapControl.ShowCenter = false;
            MapControl.CanDragMap = true;
            MapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            MapControl.DragButton = System.Windows.Input.MouseButton.Left;
        }
    }
}
