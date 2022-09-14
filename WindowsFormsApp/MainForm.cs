using RwaLib;
using RwaLib.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Klase;
using WindowsFormsApp.UserKontrole;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private TipTima tipTima;
        private Jezici jezici;
        private string selectedFifaCode;
        private const String HR = "hr";
        private const String EN = "en";
        private const String MALE = "male";
        private const String FEMALE = "female";
        private List<Player> players;
        private List<Match> matches;
        private List<UserKontrolaIgrac> selektiraniIgraci = new List<UserKontrolaIgrac>();
        private List<UserKontrolaIgrac> selektiraniOmiljeniIgraci = new List<UserKontrolaIgrac>();
        private UserKontrolaIgrac userKontrolaIgrac;
        private int BrojOmiljenih = 0;


        public MainForm()
        {
            InitializeComponent();
            try
            {
                stripStatusLabel.Text = Resources.MyResources.loading;
                List<string> postavke = Repozitorij.DohvacanjePostavki();
                if (postavke != null && postavke.Count > 1)
                {
                    jezici = postavke[0] == EN ? Jezici.Hrvatski : Jezici.Engleski;
                    tipTima = postavke[1] == MALE ? TipTima.Muski : TipTima.Zenski;
                    if (postavke.Count > 2)
                    {
                        selectedFifaCode = postavke[2];
                    }
                }
                stripStatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.Message);
                stripStatusLabel.Text = "";
            }

            Utils.PostaviKulturu(jezici);
            DohvatiTimove();
        }

        public MainForm(TipTima tipTima, Jezici jezici)
        {
            this.tipTima = tipTima;
            this.jezici = jezici;
            PostaviKulturu();
            DohvatiTimove();
        }

        private void PostaviKulturu()
        {
            Utils.PostaviKulturu(jezici);
            Controls.Clear();
            InitializeComponent();
        }

        private async void DohvatiTimove()
        {
            try
            {
                stripStatusLabel.Text = Resources.MyResources.loading;
                List<Team> teams = await Repozitorij.DohvatiTim(tipTima);
                FillComboBox(teams);
                if (selectedFifaCode != null)
                {
                    cbTeams.SelectedIndex = cbTeams.FindString(selectedFifaCode);
                }
                stripStatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                stripStatusLabel.Text = "";
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void FillComboBox(List<Team> teams)
        {
            foreach (Team team in teams)
            {
                cbTeams.Items.Add(team.FifaCode);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void cbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                stripStatusLabel.Text = Resources.MyResources.loading;
                SpremiTimskePostavke();
                selectedFifaCode = cbTeams.SelectedItem.ToString();

                this.players = Repozitorij.DohvatiPodatkeTima(tipTima, selectedFifaCode);
                if (selectedFifaCode != null)
                {
                    Repozitorij.SpremanjePostavki(jezici, tipTima, selectedFifaCode, Rezolucija.NemaRezolucije);
                }

                if (this.players == null)
                {
                    this.players = new List<Player>();
                    matches = await Repozitorij.PodaciZaTim(selectedFifaCode, tipTima);
                    foreach (Player player in matches[0].HomeTeamStatistics.StartingEleven)
                    {
                        this.players.Add(player);
                    }
                    foreach (Player player in matches[0].HomeTeamStatistics.Substitutes)
                    {
                        this.players.Add(player);
                    }
                    PostaviKartoneIGoloveZaIgrace(players, matches);
                }

                ListaIgraca();
                stripStatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                stripStatusLabel.Text = "";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PostaviKartoneIGoloveZaIgrace(List<Player> players, List<Match> matches)
        {
            foreach (Match match in matches)
            {
                foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                {
                    DodavanjeEventaIgracu(teamEvent, players);
                }
                foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                {
                    DodavanjeEventaIgracu(teamEvent, players);
                }
            }
        }

        private void DodavanjeEventaIgracu(TeamEvent teamEvent, List<Player> igraci)
        {
            foreach (Player player in igraci)
            {
                if (player.Name.Equals(teamEvent.Player))
                {
                    if (teamEvent.TypeOfEvent.Equals("goal") || teamEvent.TypeOfEvent.Equals("goal-penalty"))
                    {
                        player.ZabijeniGolovi += 1;
                    }
                    else if (teamEvent.TypeOfEvent.Equals("yellow-card"))
                    {
                        player.ZutiKartoni += 1;
                    }
                }
            }
        }
        private void ListaIgraca()
        {
            panelSource.Controls.Clear();
            panelDestination.Controls.Clear();
            foreach (Player player in players)
            {
                var playerUC = new UserKontrolaIgrac(player, player.Favorite);
                playerUC.MouseDown += OnUsercontrolMouseDown;
                playerUC.Tag = "parent";
                foreach (Control control in playerUC.Controls)
                {
                    if (control.Tag != null && control.Tag.Equals("PictureBox"))
                    {
                        control.MouseDown += DodajSliku;
                    }
                    else
                    {
                        control.Tag = "child";
                        control.MouseDown += OnUsercontrolMouseDown;
                    }

                }
                if (player.Favorite)
                {
                    panelDestination.Controls.Add(playerUC);
                }
                else
                {
                    panelSource.Controls.Add(playerUC);
                }
            }

        }

        private void OnUsercontrolMouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            var playerUC = (control.Tag.Equals("parent")) ? control as UserKontrolaIgrac : control.Parent as UserKontrolaIgrac;
            if (e.Button == MouseButtons.Left)
            {
                playerUC.selektiran = !playerUC.selektiran;
                playerUC.BorderStyle = playerUC.selektiran ? BorderStyle.Fixed3D : BorderStyle.None;
                if (playerUC.selektiran)
                {
                    if (!playerUC.player.Favorite)
                    {
                        selektiraniIgraci.Add(playerUC);
                    }
                    else
                    {
                        selektiraniOmiljeniIgraci.Add(playerUC);
                    }
                }
                else
                {
                    if (!playerUC.player.Favorite)
                    {
                        selektiraniIgraci.Remove(playerUC);
                    }
                    else
                    {
                        selektiraniOmiljeniIgraci.Remove(playerUC);
                    }
                }


            }
            else
            {
                userKontrolaIgrac = playerUC;
            }

        }


        private void DodajSliku(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            var ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.bmp;*.jpg;*jpeg;*.png|All|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                UserKontrolaIgrac playerUC = picture.Parent as UserKontrolaIgrac;
                string filePath = "../../../WindowsFormsApp/Resources/" + playerUC.player.Name + ".jpg";
                playerUC.player.Image = filePath;
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.Copy(ofd.FileName, filePath);
                picture.ImageLocation = filePath;
            }
            SpremiTimskePostavke();
        }

        private void MainFormZatvoren(object sender, FormClosedEventArgs e)
        {
            SpremiTimskePostavke();
        }

        private void SpremiTimskePostavke()
        {
            try
            {
                if (selectedFifaCode != null && players != null)
                {
                    Repozitorij.SpremanjePodatakaTima(players, tipTima, selectedFifaCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_ZatvaranjeForme(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var dialogResult = new FormaZaPotvrdu().ShowDialog();
                if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.No || dialogResult == DialogResult.Abort)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnRangirajPoGolovima_Click(object sender, EventArgs e)
        {
            if (players != null)
            {
                new RankIPrint(players, TipRanka.GOALS).ShowDialog();
            }
            else
            {
                MessageBox.Show(Resources.MyResources.selectCountryError);
            }
        }

        private void btnRangirajPoKartonima_Click(object sender, EventArgs e)
        {
            if (players != null)
            {
                new RankIPrint(players, TipRanka.YELLOW_CARDS).ShowDialog();
            }
            else
            {
                MessageBox.Show(Resources.MyResources.selectCountryError);
            }
        }

        private async void btnRangirajPoPosjetiteljima(object sender, EventArgs e)
        {
            if (players != null)
            {
                if (matches == null)
                {
                    try
                    {
                        matches = await Repozitorij.PodaciZaTim(selectedFifaCode, tipTima);
                        new RankIPrint(matches).ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    new RankIPrint(matches).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(Resources.MyResources.selectCountryError);
            }
        }

        private void postavkeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpremiTimskePostavke();
            this.Hide();
            var settingsForm = new PocetnePostavke();
            settingsForm.Closed += (s, args) => this.Close();
            settingsForm.Show();
        }

        private void DodavanjeUOmiljene(object sender, EventArgs e)
        {
            MicanjeUDrugiPanel(selektiraniIgraci, panelSource, panelDestination, true);
        }

        
        private void MicanjeIzOmiljenih(object sender, EventArgs e)
        {
            MicanjeUDrugiPanel(selektiraniOmiljeniIgraci, panelDestination, panelSource, false);
        }

        private void MicanjeUDrugiPanel(List<UserKontrolaIgrac> odabrani, FlowLayoutPanel from, FlowLayoutPanel to, bool omiljeni)
        {
            bool removeSelectedPlayerCU = false;
            if (!userKontrolaIgrac.selektiran)
            {
                odabrani.Add(userKontrolaIgrac);
                removeSelectedPlayerCU = true;
            }
            if ((odabrani.Count + to.Controls.Count > 3) && omiljeni)
            {
                MessageBox.Show("To many players");
                if (removeSelectedPlayerCU)
                {
                    odabrani.RemoveAt(odabrani.Count - 1);
                }
                return;
            }
            foreach (UserKontrolaIgrac playerUC in odabrani)
            {
                playerUC.selektiran = false;
                playerUC.BorderStyle = BorderStyle.None;
                playerUC.OznaciZvjezdicomOmiljene(omiljeni);
                from.Controls.Remove(playerUC);
                to.Controls.Add(playerUC);
            }
            if (omiljeni)
            {
                selektiraniIgraci.Clear();
            }
            else
            {
                selektiraniOmiljeniIgraci.Clear();
            }
        }

    }
}
