﻿using System;
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
using Microsoft.Practices.Prism.Regions;

namespace WpfStockTrader.Modules.News.Article
{
    /// <summary>
    /// Interaction logic for ArticleView.xaml
    /// </summary>
    [ViewSortHint("03")]
    public partial class ArticleView : UserControl
    {
        public ArticleView(ArticleViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
