using RwaLib.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UserKontrole
{
    public partial class UserKontrolaIgrac : UserControl
    {
        public Player player;
        public bool selektiran;
        public UserKontrolaIgrac()
        {
            InitializeComponent();
        }
        public UserKontrolaIgrac(Player player, bool Omiljeni)
        {
            InitializeComponent();
            this.player = player;
            lblIme.Text = player.Name;
            lblBroj.Text = player.ShirtNumber.ToString();
            lblKapetan.Text = player.Captain ? "C" : "";
            lblPozicija.Text = player.Position;
            if (player.Image != null && !player.Image.Equals(""))
            {
                pbSlika.ImageLocation = player.Image;
            }
            selektiran = false;
            OznaciZvjezdicomOmiljene(Omiljeni);
        }

        public void OznaciZvjezdicomOmiljene(bool Favourite)
        {
            player.Favorite = Favourite;
            pblsFavorite.Image = Favourite ? Resources.MyResources.star : Resources.MyResources.starEmpty;
        }

        private void UserKontrolaIgrac_Load(object sender, EventArgs e)
        {

        }
    }
}
