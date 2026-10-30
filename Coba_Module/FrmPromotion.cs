using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Coba_Module.GlobalClass;

namespace Coba_Module
{
    public partial class FrmPromotion : Form
    {
        EsemkaCorporationEntities1 db;
        public FrmPromotion()
        {
            db = new EsemkaCorporationEntities1();
            InitializeComponent();
            var dapature = db.positions.Where(a => a.employee_id == vid).FirstOrDefault();
            var items = (from pos in db.positions
                         join job in db.jobs on pos.job_id equals job.id
                         join emp in db.employees on pos.employee_id equals emp.id
                         join dep in db.departments on job.department_id equals dep.id
                         join lvl in db.job_level on job.job_level_id equals lvl.id
                         select new
                         {
                             txtPosition = job.name,
                             vname = lvl.name,
                             dep = dep.name,
                             job.supervisor_job_id
                         }).Where(a => a.supervisor_job_id == dapature.job.supervisor_job_id).FirstOrDefault();
            txtName.Text = vname;
            txtDepature.Text = items.dep;
            txtPosition.Text = items.txtPosition;
            txtjob.Text = items.vname;
            load();
        }
        private void load()
        {
            var items = from o in db.jobs
                        join i in db.departments on o.id equals i.id
                        from g in db.job_level
                        join e in db.employees on g.id equals e.id
                        select new
                        {
                            Department = i.name,
                            Position = o.name,
                            joblvl = o.id,
                        };
            DGV.DataSource = items.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = DGV.Rows[e.RowIndex].Cells["cjoblvl"].Value;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == cAction.Index)
                {
                    if (MessageBox.Show("apapkah anda yakin", "konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sta = "p";
                        promotion mas = new promotion
                        {
                            job_id = Convert.ToInt32(value),
                            employee_id = vid,
                            status = sta,
                            created_at = DateTime.Now,
                        };
                        db.promotions.Add(mas);
                        db.SaveChanges();
                        MessageBox.Show("Sudah berhasil di input Pending yak");
                        cAction.Text = "Pending";
                    }
                }
                else
                {
                    MessageBox.Show("Klick yang benar");
                }
            }
            else 
            {
                MessageBox.Show("Error code 201");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }
    }
}
