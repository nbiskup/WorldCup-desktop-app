using RwaLib.Modeli;
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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for InfoIgrac.xaml
    /// </summary>
    public partial class InfoIgrac : Window
    {
        public InfoIgrac(Player p)
        {
            InitializeComponent();
            NapuniPodacima(p);
        }

        private void NapuniPodacima(Player p)
        {
            label1.Content = p.Name;
            label2.Content = p.ShirtNumber;
            label3.Content = p.Image;
            label4.Content = p.Position;
            if (p.Captain == true)
            {
                label5.Content = "C";

            }
            label6.Content = p.ZabijeniGolovi;
            label7.Content = p.ZutiKartoni;
        }
    }
}
