using RwaLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (!Repozitorij.PostojecePostavke())
            {
                new MainWindow().Show();
            }
            else if (Repozitorij.PostojecePostavke() && Repozitorij.DohvacanjePostavki().Count < 4)
            {
                Repozitorij.PostojecePostavke();
                new MainWindow().Show();
            }
            else
            {
                new NogometniTeren().Show();
            }
        }
    }
}
