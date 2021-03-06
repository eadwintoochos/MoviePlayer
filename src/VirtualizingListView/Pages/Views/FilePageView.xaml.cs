﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VirtualizingListView.Pages.ViewModel;

namespace VirtualizingListView.Pages
{
    /// <summary>
    /// Interaction logic for FilePageView.xaml
    /// </summary>
    public partial class FilePageView : Page
    {
        public FilePageView()
        {
            InitializeComponent();
        }
        public FilePageView(NavigationService navigationService):this()
        {
            this.DataContext = new FilePageViewModel(navigationService,this.Dispatcher);
        }

        private void collections_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
