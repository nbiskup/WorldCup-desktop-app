using RwaLib;
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

namespace WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbItemGender = (ComboBoxItem)cbSelectGender.SelectedItem;
            ComboBoxItem cbItemLanguage = (ComboBoxItem)cbSelectLanguage.SelectedItem;
            ComboBoxItem cbItemScreenSize = (ComboBoxItem)cbSelectScreenSize.SelectedItem;

            Rezolucija rezolucija = Rezolucija.Mala;

            if (cbItemGender == null || cbItemLanguage == null || cbItemScreenSize == null)
            {
                MessageBox.Show(Properties.Resources.selectAllSettings);
                return;
            }

            var jezici = cbItemLanguage.Tag.Equals("hr") ? RwaLib.Jezici.Hrvatski : RwaLib.Jezici.Engleski;
            var spol = cbItemGender.Tag.Equals("male") ? RwaLib.TipTima.Muski : RwaLib.TipTima.Zenski;

            Utils.PostaviKulturu(jezici);

            List<string> listaPostavki = Repozitorij.DohvacanjePostavki();

            switch (cbSelectScreenSize.SelectedIndex)
            {
                case 0:
                    rezolucija = Rezolucija.Mala;
                    break;
                case 1:
                    rezolucija = Rezolucija.Srednja;
                    break;
                case 2:
                    rezolucija = Rezolucija.Velika;
                    break;
            }

            try
            {
                Repozitorij.SpremanjePostavki(jezici, spol, "", rezolucija);
                new NogometniTeren().Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
