﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Kursach.CodeFirst.KursachContexxt db = new CodeFirst.KursachContexxt();
                var LogUser = await db.Users
                    .AsQueryable()
                    .Where(x => x.UserName == LoginBox.Text && x.Password == PassBox.Password)
                    .ToListAsync();
                if (LogUser.Count > 0)
                    MessageBox.Show("кк");
                else MessageBox.Show("Не сегодня");
            }
        }
    }
}
