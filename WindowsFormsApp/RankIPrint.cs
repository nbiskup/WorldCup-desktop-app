
using RwaLib.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Klase;
using WindowsFormsApp.UserKontrole;

namespace WindowsFormsApp
{
    public partial class RankIPrint : Form
    {
        private TipRanka tipRanka;
        private List<Player> SortiraniIgraci = new List<Player>();
        private List<RwaLib.Modeli.Match> SortiraneUtakmice = new List<RwaLib.Modeli.Match>();
        

        public RankIPrint()
        {
            InitializeComponent();
        }

        public RankIPrint(List<Player> players, TipRanka tipRanka)
        {
            InitializeComponent();
            if (tipRanka == TipRanka.GOALS)
            {
                SortiraniIgraci = players.OrderByDescending(p => p.ZabijeniGolovi).ToList();
            }
            else if (tipRanka == TipRanka.YELLOW_CARDS)
            {
                SortiraniIgraci = players.OrderByDescending(p => p.ZutiKartoni).ToList();
            }
            this.tipRanka = tipRanka;

            NapuniFlowPanelIgracima();

        }

        public RankIPrint(List<RwaLib.Modeli.Match> utakmice)
        {
            InitializeComponent();
            flpRankKontener.WrapContents = true;
            SortiraneUtakmice = utakmice.OrderByDescending(m => int.Parse(m.Attendance)).ToList();
            NapuniFlowPanelUtakmicama();
        }

        private void NapuniFlowPanelUtakmicama()
        {
            foreach (RwaLib.Modeli.Match match in SortiraneUtakmice)
            {
                flpRankKontener.Controls.Add(new MatchRank(match));
            }
        }

        private void NapuniFlowPanelIgracima()
        {
            for (int i = 0; i < SortiraniIgraci.Count; i++)
            {
                Player player = SortiraniIgraci[i];
                flpRankKontener.Controls.Add(new PlayerRank(player, tipRanka, i + 1));
            }
        }

        private void RankIPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
