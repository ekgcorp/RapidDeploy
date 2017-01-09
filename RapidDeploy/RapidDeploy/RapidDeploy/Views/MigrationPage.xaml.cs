using System;
using System.Collections.Generic;
using RapidDeploy.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace RapidDeploy.Views
{
    public sealed partial class MigrationPage : Page
    {
        public MigrationPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

    }
}