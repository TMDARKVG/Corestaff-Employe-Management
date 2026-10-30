using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Coba_Module.GlobalClass;

namespace Coba_Module
{
    public partial class FrmMain : Form
    {
        EsemkaCorporationEntities1 db;
        public FrmMain()
        {
            db = new EsemkaCorporationEntities1();
            InitializeComponent();
            //label1.Text = vname;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmProfile profile = new FrmProfile();
            profile.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmMutation mutasi = new FrmMutation();
            mutasi.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPromotion promo = new FrmPromotion();
            promo.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Text = vname;
        }
    }
}
