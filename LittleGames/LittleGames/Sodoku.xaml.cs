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
using System.Windows.Shapes;

namespace LittleGames {
    /// <summary>
    /// Interaction logic for Sodoku.xaml
    /// </summary>
    public partial class Sodoku : Window {
        private MainWindow m_parent;
        public Sodoku(MainWindow parent) {
            m_parent = parent;
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e) {
            m_parent.Show();
        }
    }
}
