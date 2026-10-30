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
using static Coba_Module.GlobalClass;

namespace Coba_Module
{
    public partial class FrmMutation : Form
    {
        EsemkaCorporationEntities1 db;
        public FrmMutation()
        {
            db = new EsemkaCorporationEntities1();
            InitializeComponent();
            load();
            var depature = db.positions.Where(a => a.employee_id == vid).FirstOrDefault(); 
            var items = (from pos in db.positions
                         join job in db.jobs on pos.job_id equals job.id
                         join emp in db.employees on pos.employee_id equals emp.id
                         join dep in db.departments on job.department_id equals dep.id
                         join lvl in db.job_level on job.job_level_id equals lvl.id
                         select new
                         {
                             txtPosition = job.name,
                             job = lvl.name,
                             dep = dep.name,
                             job.supervisor_job_id
                         }).Where(a=>a.supervisor_job_id == depature.job.supervisor_job_id).FirstOrDefault();
            txtName.Text = vname;
            txtDep.Text = items.dep;
            txtPos.Text = items.txtPosition;
            txtJob.Text = items.job;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }
        private void load() 
        {
            var user = db.employees.Where(a=>a.id == vid).FirstOrDefault();
            var posi = db.positions.Where(a=>a.employee_id == user.id).FirstOrDefault();
            DGV.DataSource = (from pos in db.positions
                               join job in db.jobs on pos.job_id equals job.id
                               join emp in db.employees on pos.employee_id equals emp.id
                               join dep in db.departments on job.department_id equals dep.id
                               select new
                               {
                                   dep.name,
                                   tes = job.name,
                                   job.job_level_id
                               }).Where(a=>a.job_level_id <= posi.id).ToList();
        }
    }
}
