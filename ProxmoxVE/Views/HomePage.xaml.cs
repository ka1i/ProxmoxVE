﻿using Microsoft.UI.Xaml.Controls;

using ProxmoxVE.ViewModels;

namespace ProxmoxVE.Views;

public sealed partial class HomePage : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePage()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
