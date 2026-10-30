using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Coba_Module.GlobalClass;

namespace Coba_Module
{
    public partial class FrmProfile : Form
    {
        EsemkaCorporationEntities1 db;

        public FrmProfile()
        {
            db = new EsemkaCorporationEntities1();
            InitializeComponent();
            var user = db.employees.Where(a => a.id == vid).FirstOrDefault();
            var dapature = db.positions.Where(a => a.employee_id == user.id).FirstOrDefault();
            var items = (from pos in db.positions
                         join job in db.jobs on pos.job_id equals job.id
                         join emp in db.employees on pos.employee_id equals emp.id
                         join dep in db.departments on job.department_id equals dep.id
                         join lvl in db.job_level on job.job_level_id equals lvl.id
                         select new
                         {
                             txtName = user.name,
                             txtEmail = user.email,
                             txtPhone = user.phone_number,
                             dtpHire = user.hire_date,
                             txtPosition = job.name,
                             txtJob = lvl.name,
                             txtDepature = dep.name,
                             job.supervisor_job_id
                         }).Where(a => a.supervisor_job_id == dapature.job.supervisor_job_id).FirstOrDefault();
            txtName.Text = items.txtName;
            txtEmail.Text = items.txtEmail;
            txtPhone.Text = items.txtPhone;
            dtpHire.Text = items.dtpHire.ToString();
            txtPosition.Text = items.txtPosition;
            txtJob.Text = items.txtJob;
            txtDepature.Text = items.txtDepature;
            load1();
            load2();
            load3();
        }
        private void load2()
        {
            var user = db.employees.Where(a => a.id == vid).FirstOrDefault();
            var posi = db.positions.Where(a => a.employee_id == user.id).FirstOrDefault();

            dataGridView2.DataSource = (from pos in db.positions
                                        join job in db.jobs on pos.job_id equals job.id
                                        join emp in db.employees on pos.employee_id equals emp.id
                                        select new
                                        {
                                            emp.name,
                                            jobname = job.name,
                                            job.supervisor_job_id,
                                            pos.deleted_at,
                                        }).Where(a => a.supervisor_job_id == posi.job.supervisor_job_id && a.deleted_at == null).ToList();
        }
        private void load1()
        {
            var user = db.employees.Where(a => a.id == vid).FirstOrDefault();
            var posi = db.positions.Where(a => a.employee_id == user.id).FirstOrDefault();
            var jobs = db.jobs.Where(a => a.id == posi.job_id).FirstOrDefault();

            dataGridView1.DataSource = (from pos in db.positions
                                        join job in db.jobs on pos.job_id equals job.id
                                        join emp in db.employees on pos.employee_id equals emp.id
                                        select new
                                        {
                                            emp.name,
                                            jobname = job.name,
                                            job.job_level_id,
                                            pos.deleted_at,
                                        }).Where(a => a.job_level_id < jobs.job_level_id && a.deleted_at == null).ToList();
        }
        private void load3()
        {
            var user = db.employees.Where(a => a.id == vid).FirstOrDefault();
            var posi = db.positions.Where(a => a.employee_id == user.id).FirstOrDefault();
            //var liat = db.departments.Where(a=>a)
            var latest = db.jobs.Where(a => a.id == posi.job_id).FirstOrDefault();

            dataGridView3.DataSource = (from job in db.jobs
                                        join pos in db.positions on job.id equals pos.job_id
                                        join dep in db.departments on job.department_id equals dep.id
                                        join emp in db.employees on pos.employee_id equals emp.id
                                        where pos.employee_id == user.id
                                        select new
                                        {
                                            PositionId = pos.id,
                                            jobname = job.name,
                                            name = dep.name,
                                            //StartDate = pos.start_date, // Jika ada kolom tanggal mulai
                                            //EndDate = pos.end_date,     // Jika ada kolom tanggal selesai
                                            IsDeleted = pos.deleted_at,
                                        }).ToList();
                                        //).Where(a => a.department_id == latest.department_id ).ToList() ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain mian = new FrmMain();
            mian.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if(Position.)
        }
    }
}
