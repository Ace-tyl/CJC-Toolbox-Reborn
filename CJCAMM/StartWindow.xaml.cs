﻿using System.Windows;

namespace CJC_Advanced_Midi_Merger
{
    /// <summary>
    /// SaveWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StartWindow : Window
    {
        public bool ss;
        public StartWindow()
        {
            InitializeComponent();
            ss = false;
        }
        public void okclick(object sender, RoutedEventArgs e)
        {
            ss = true;
            Close();
        }
    }
}
