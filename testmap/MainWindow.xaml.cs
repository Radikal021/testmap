using DevExpress.Xpf.Map;
using System.Windows;



namespace testmap
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ایجاد یک نقشه
            
            MapItemLayer mapLayer = new MapItemLayer();
            mapLayer.Data = new VectorItemsLayerData();

            // اضافه کردن نقشه به MapControl
            mapControl.Layers.Add(mapLayer);

            // افزودن مثالی از نقشه (برای این مثال از یک نقطه به عنوان نمونه استفاده شده است)
            MapDot mapDot = new MapDot();
            mapDot.Location = new GeoPoint(40.7128, -74.0060); // مختصات نمونه
            mapLayer.Items.Add(mapDot);

            // تنظیم نمایش نقشه
            mapControl.ZoomLevel = 10;
            mapControl.CenterPoint = mapDot.Location;
        }
    }
}
