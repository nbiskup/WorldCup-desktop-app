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
    /// Interaction logic for UserControlaIgrac.xaml
    /// </summary>
    public partial class UserControlaIgrac : UserControl
    {
        public Player player;
        public UserControlaIgrac()
        {
            InitializeComponent();
        }
        
        public UserControlaIgrac(Player player)
        {
            this.player = player;
            InitializeComponent();
            kontrola.MouseDown += this.Kontrola_MouseDown;
            lblIme.Content = player.Name;
            lblBroj.Content = player.ShirtNumber;
        }

        private void Kontrola_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new InfoIgrac(player).ShowDialog();
        }
    }
}
