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
using WindowsFormsApp.Klase;

namespace WindowsFormsApp.UserKontrole
{
    public partial class PlayerRank : UserControl
    {
        private Player player;
        public PlayerRank()
        {
            InitializeComponent();
        }

        public PlayerRank(Player player, TipRanka rankType, int rank)
        {
            InitializeComponent();
            this.player = player;
            lblImee.Text = player.Name;
            lblBrojEvenata.Text = rankType == TipRanka.GOALS ? Resources.MyResources.goals + player.ZabijeniGolovi.ToString()
                : Resources.MyResources.yellowCards + player.ZutiKartoni.ToString();
            if (player.Image != null && !player.Image.Equals(""))
            {
                pbSlika.ImageLocation = player.Image;
            }
            lblRank.Text = Resources.MyResources.rank + rank.ToString();

        }
        private void PlayerRank_Load(object sender, EventArgs e)
        {

        }
    }
}
