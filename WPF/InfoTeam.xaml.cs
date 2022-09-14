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
    /// Interaction logic for InfoTeam.xaml
    /// </summary>
    public partial class InfoTeam : Window
    {
        Team tim;
        public InfoTeam(Team tim)
        {
            InitializeComponent();
            this.tim = tim;

            DohvatiInfoReprezentacije(tim);
        }

        private void DohvatiInfoReprezentacije(Team tim)
        {
            label1.Content = tim.Country;
            label2.Content = tim.FifaCode;
            label3.Content = tim.GamesPlayed;
            label4.Content = tim.Wins;
            label5.Content = tim.Losses;
            label6.Content = tim.Draws;
            label7.Content = tim.GoalsFor;
            label8.Content = tim.GoalsAgainst;
            label9.Content = tim.GoalDifferential;
        }
    }
}
