using RwaLib;
using RwaLib.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for NogometniTeren.xaml
    /// </summary>
    public partial class NogometniTeren : Window
    {
        public Match utakmica;
        private Jezici jezici;
        private TipTima tipTima;
        private List<Team> teams;
        private List<Match> matches;
        private String selectedFavouriteFifaCode;
        private String selectedOposingFifaCode;


        public NogometniTeren()
        {
            InitializeComponent();
            TehnickePostavke();
            DohvatiTimove();
        }

        private async void DohvatiTimove()
        {
            try
            {
                teams = await Repozitorij.DohvatiTim(tipTima);
                FillComboBox();
                DohvatiPostavke();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBox()
        {
            foreach (Team team in teams)
            {
                cbFavouriteteam.Items.Add(team);
            }
            cbFavouriteteam.SelectedIndex = 0;
        }

        private void DohvatiPostavke()
        {
            try
            {
                var settings = Repozitorij.DohvacanjePostavki();
                if (settings != null && settings.Count > 1)
                {
                    selectedFavouriteFifaCode = settings[2];
                    cbFavouriteteam.SelectedItem = selectedFavouriteFifaCode;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TehnickePostavke()
        {
            List<string> postavke = Repozitorij.DohvacanjePostavki();

            jezici = postavke[0] == "en" ? Jezici.Engleski : Jezici.Hrvatski;
            tipTima = postavke[1] == "male" ? TipTima.Muski : TipTima.Zenski;


            //Mala,Srednja,Velika,NemaRezolucije
            switch (postavke[3])
            {
                case "Mala":
                    this.Width = 1000;
                    this.Height = 700;
                    break;
                case "Srednja":
                    this.Width = 1500;
                    this.Height = 700;
                    break;
                case "Velika":
                    this.Width = 1700;
                    this.Height = 850;
                    break;
            }
        }

        private void FillGrid()
        {
            Match match = GetMatch();
            if (match == null) return;
            List<Player> OmiljeniIgraci = new List<Player>();
            List<Player> SuparnickiIgraci = new List<Player>();
            if (match.HomeTeam.Code.Equals(selectedFavouriteFifaCode))
            {
                OmiljeniIgraci = match.HomeTeamStatistics.StartingEleven;
                SuparnickiIgraci = match.AwayTeamStatistics.StartingEleven;

            }
            else
            {
                OmiljeniIgraci = match.AwayTeamStatistics.StartingEleven;
                SuparnickiIgraci = match.HomeTeamStatistics.StartingEleven;
            }
            if (match.HomeTeam.Code == ((Team)cbFavouriteteam.SelectedItem).FifaCode)
            {
                lblRezultat.Content = $"{match.HomeTeam.Goals} : {match.AwayTeam.Goals} ";
            }
            else
            {
                lblRezultat.Content = $"{match.AwayTeam.Goals} : {match.HomeTeam.Goals} ";

            }

            DodajIgraceUGrid(OmiljeniIgraci, true);
            DodajIgraceUGrid(SuparnickiIgraci, false);
        }

        private Match GetMatch()
        {
            if (matches == null) return null;
            foreach (Match match in matches)
            {
                if (match.HomeTeam.Code.Equals(selectedFavouriteFifaCode)
                    && match.AwayTeam.Code.Equals(selectedOposingFifaCode))
                {
                    return match;
                }
                if (match.HomeTeam.Code.Equals(selectedOposingFifaCode)
                    && match.AwayTeam.Code.Equals(selectedFavouriteFifaCode))
                {
                    return match;
                }
            }
            return null;
        }

        private void DodajIgraceUGrid(List<Player> players, bool OmiljeniTim)
        {
            int goalieColumn = OmiljeniTim ? 0 : 7;
            var goalie = players[0];
            DodajIgracaUGrid(goalie, goalieColumn, 2);
            int defCount = 0;
            int midCount = 0;
            int attCount = 0;
            foreach (Player currentPlayer in players)
            {
                if (currentPlayer.Position.Equals("Defender"))
                {
                    int column = OmiljeniTim ? 1 : 6;
                    DodajIgracaUGrid(currentPlayer, column, defCount);
                    defCount += 1;

                }
                else if (currentPlayer.Position.Equals("Midfield"))
                {
                    int column = OmiljeniTim ? 2 : 5;
                    DodajIgracaUGrid(currentPlayer, column, midCount);
                    midCount += 1;
                }
                else if (currentPlayer.Position.Equals("Forward"))
                {
                    int column = OmiljeniTim ? 3 : 4;
                    DodajIgracaUGrid(currentPlayer, column, attCount);
                    attCount += 1;
                }
            }

        }

        private void DodajIgracaUGrid(Player player, int x, int y)
        {
            UserControlaIgrac igrac = new UserControlaIgrac(player);

            Grid.SetColumn(igrac, x);
            Grid.SetRow(igrac, y);
            Grid.SetColumnSpan(gridField, 5);
            gridField.Children.Add(igrac);
        }

        private void saveTeamData()
        {
            try
            {
                var selectedFifaCode = cbFavouriteteam.SelectedItem as Team;
                var players = Repozitorij.DohvatiPodatkeTima(tipTima, selectedFifaCode.FifaCode);
                if (selectedFifaCode != null && players != null)
                {
                    Repozitorij.SpremanjePodatakaTima(players, tipTima, selectedFifaCode.FifaCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NogomentiTeren_FormClosed(object sender, CancelEventArgs e)
        {
            saveTeamData();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MsgBoxYesNo MsgBox = new MsgBoxYesNo();
            MsgBox.ShowDialog();
            e.Cancel = true;
        }

        private void btnPostavke_Click(object sender, RoutedEventArgs e)
        {
            saveTeamData();
            this.Hide();
            var settingsForm = new MainWindow();
            settingsForm.Closed += (s, args) => this.Close();
            settingsForm.Show();
        }

        private async void btnDomaci_Click(object sender, RoutedEventArgs e)
        {
            List<Team> listaTimova = await Repozitorij.DohvatiTim(tipTima);

            foreach (var team in listaTimova)
            {
                if (((Team)(cbFavouriteteam.SelectedItem)).FifaCode == team.FifaCode)
                {
                    new InfoTeam(team).ShowDialog();
                }
            }
        }

        private async void btnGosti_Click(object sender, RoutedEventArgs e)
        {
            List<Team> listaTimova = await Repozitorij.DohvatiTim(tipTima);

            foreach (var team in listaTimova)
            {
                if (cbAwayTeam.Text == team.FifaCode)
                {
                    new InfoTeam(team).ShowDialog();
                }
            }
        }

        private async void cbFavouriteteam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                selectedFavouriteFifaCode = cbFavouriteteam.SelectedItem.ToString();

                matches = await Repozitorij.PodaciZaTim(selectedFavouriteFifaCode, tipTima);

                HashSet<string> set = new HashSet<string>();
                foreach (Match match in matches)
                {
                    set.Add(match.HomeTeam.Code);
                    set.Add(match.AwayTeam.Code);

                }

                foreach (string code in set)
                {
                    cbAwayTeam.Items.Add(code);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbOposingTeamm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedOposingFifaCode = cbAwayTeam.SelectedItem.ToString();
            if (selectedFavouriteFifaCode != null && selectedOposingFifaCode != null)
            {
                gridField.Children.Clear();
                FillGrid();
            }
        }
    }
}
