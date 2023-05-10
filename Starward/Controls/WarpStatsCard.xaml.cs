﻿// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Starward.Models;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Starward.Controls;

public sealed partial class WarpStatsCard : UserControl
{

    public WarpStatsCard()
    {
        this.InitializeComponent();
    }



    public WarpTypeStats WarpTypeStats
    {
        get { return (WarpTypeStats)GetValue(WarpTypeStatsProperty); }
        set { SetValue(WarpTypeStatsProperty, value); }
    }

    // Using a DependencyProperty as the backing store for WarpTypeStats.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty WarpTypeStatsProperty =
        DependencyProperty.Register("WarpTypeStats", typeof(WarpTypeStats), typeof(WarpStatsCard), new PropertyMetadata(null));





}