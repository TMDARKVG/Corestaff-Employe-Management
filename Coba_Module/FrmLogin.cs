using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Coba_Module.GlobalClass;

namespace Coba_Module
{ 
    public partial class FrmLogin : Form
    {
        EsemkaCorporationEntities1 db;
        public FrmLogin()
        {
            db = new EsemkaCorporationEntities1();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                var items = db.employees.Where(a => a.email.Equals(textBox1.Text)).SingleOrDefault();
                if (items != null)
                {
                    if (items.password.Equals(textBox2.Text))
                    {
                        var user = db.employees.Where(a => a.email == textBox1.Text).FirstOrDefault();
                        FrmMain main = new FrmMain();
                        vid = user.id;
                        vname = user.name;
                        //vjobs = ;
                        vpos = user.positions.ToString();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        label3.Text = "Password salah";
                    }
                }
                else
                {
                    label3.Text = "Username salah";
                }
            }
            else
            {
                label3.Text = "Isi terlebih dahulu";
            }
        }
    }
}
