using RwaLib;
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

namespace WindowsFormsApp
{
    public partial class PocetnePostavke : Form
    {
        private TipTima tipTima;
        private Jezici jezici;
        private const string HR = "hr";
        private const string EN = "en";
        private const string MALE = "male";
        private const string FEMALE = "female";

        private void PostaviKulturu()
        {
            Utils.PostaviKulturu(jezici);
            Controls.Clear();
            InitializeComponent();
            NapuniComboBox();
        }

        private void NapuniComboBox()
        {
            cbSpol.Items.Add(Resources.MyResources.male);
            cbSpol.Items.Add(Resources.MyResources.female);
            cbSpol.SelectedIndex= 0;    
        }

        public PocetnePostavke()
        {
            try
            {
                List<string> postavke = Repozitorij.DohvacanjePostavki();
                if (postavke != null && postavke.Count > 1)
                {
                    jezici = postavke[0] == EN ? Jezici.Hrvatski : Jezici.Engleski;
                    tipTima = postavke[1] == MALE ? TipTima.Muski : TipTima.Zenski;
                }
            }
            catch (Exception ex)
            {
                jezici = Jezici.Hrvatski;
                tipTima = TipTima.Muski;
                MessageBox.Show("ERROR\n" + ex.Message);
            }

            Utils.PostaviKulturu(jezici);
            InitializeComponent();
            NapuniComboBox();
        }

        private void btnMjenjanjeJezika_Click(object sender, EventArgs e)
        {
            if (jezici == Jezici.Hrvatski)
            {

                jezici = Jezici.Engleski;
                PostaviKulturu();
            }
            else
            {

                jezici = Jezici.Hrvatski;
                PostaviKulturu();
            }
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PocetnePostavke_Load(object sender, EventArgs e)
        {
            tipTima = (cbSpol.SelectedItem.Equals("Male")
               || cbSpol.SelectedItem.Equals("Muski")) ? TipTima.Muski : TipTima.Zenski;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (new FormaZaPotvrdu().ShowDialog() == DialogResult.OK)
            {
                if (cbSpol.SelectedItem == null)
                {
                    MessageBox.Show(Resources.MyResources.ComboBoxItemNotSelected);
                    return;
                }
                try
                {
                    Repozitorij.SpremanjePostavki(jezici, tipTima, null, Rezolucija.NemaRezolucije);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR\n" + ex.Message);
                }
                this.Hide();
                var mainForm = new MainForm(tipTima, jezici);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private void ZatvaranjePostavki(object sender, FormClosingEventArgs e)
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
    }
}
