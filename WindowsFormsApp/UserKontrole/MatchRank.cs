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
    public partial class MatchRank : UserControl
    {
        public MatchRank(RwaLib.Modeli.Match match)
        {
            InitializeComponent();
            lblLokacija.Text = Resources.MyResources.location + match.Location;
            lblGledaoci.Text = Resources.MyResources.attendance + match.Attendance;
            lblDomaciTim.Text = Resources.MyResources.homeTeam + match.HomeTeamCountry;
            lblGostujuciTim.Text = Resources.MyResources.awayTeam + match.AwayTeamCountry;
        }

        
    }
}
