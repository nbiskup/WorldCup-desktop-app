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
    public partial class MsgBoxYesNo : Window
    {
        public MsgBoxYesNo()
        {
            InitializeComponent();
        }

        private void Potvrda(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                Yes_Click(sender, e);
            }
            else if (e.Key == Key.Escape)
            {
                No_Click(sender, e);
            }
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Application.Current.Shutdown();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
