using System;
using RapidDeploy.ViewModels;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace RapidDeploy.Views
{
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MapControl1.Center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = 32.695,
                    Longitude = -96.897
                });
            MapControl1.ZoomLevel = 12;
            MapControl1.LandmarksVisible = true;
            MapControl1.MapServiceToken = "58iQZ0Gy4Mdk3aIFjyGa~l5meShpcbixLnkKK6saL7w~AncFlWvlfApmXRiW48YB0mUxGt3CbunywLoSFlwP7mFko2B6dSiD-djo4x08g3Qh";
        }
        //private void AddMapIcon()
        //{
        //    MapIcon MapIcon1 = new MapIcon();
        //    MapIcon1.Location = new Geopoint(new BasicGeoposition()
        //    {
        //        Latitude = 32.695,
        //        Longitude = -96.897
        //    });
        //    MapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
        //    MapIcon1.Title = "Space Needle";
        //    MapControl1.MapElements.Add(MapIcon1);
        //}
    }
}
