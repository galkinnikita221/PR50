﻿using Microsoft.Win32;
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
using Word_Galkin.Context;

namespace Word_Galkin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void Report(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Files (*docx)|*.docx";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                OwnerContext.Report(sfd.FileName);
            }
        }

        public void LoadRooms()
        {
            for (int i = 1; i < 20; i++) Parent.Children.Add(new Elements.Room(i));
        }
    }
}
