using lap_lich.all_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_lich
{
    public partial class A_job : UserControl
    {
        private plain_item _job;
        public plain_item Job { get => _job; set => _job = value; }

        private event EventHandler job_delete;
        public event EventHandler Job_Delete
        {
            add { job_delete += value; }
            remove { job_delete -= value; }
        }


        public event EventHandler job_update;
        public event EventHandler Job_Update
        {
            add { job_update += value; }
            remove { job_update -= value; }
        }


        public A_job(plain_item a_job)
        {
            InitializeComponent();
            this.Job = a_job;
            aj_cb_status.DataSource = plain_item.list_status;

            show_infor(a_job);
        }

        private void show_infor(plain_item job)
        {
            aj_tb_job.Text = job.Job;
            aj_nud_from_h.Value = job.Start_time.X;
            aj_nud_from_minute.Value = job.Start_time.Y;
            aj_nup_to_h.Value = job.End_time.X;
            aj_nup_to_minute.Value = job.End_time.Y;
            aj_cb_status.SelectedIndex = plain_item.list_status.IndexOf(job.Status);


            aj_cb_done.Checked = job.Status == "done" ? true : false;


        }

        private void aj_bt_delete_Click(object sender, EventArgs e)
        {
 

            if (job_delete != null)
            {
                job_delete(this, new EventArgs());
            }
        }

        private void aj_bt_edit_Click(object sender, EventArgs e)
        {
            Job.Job = aj_tb_job.Text;
            Job.Title = "title: " + aj_tb_job.Text;
            Job.Status = aj_cb_status.SelectedItem.ToString();
            aj_cb_status.SelectedIndex = plain_item.list_status.IndexOf(Job.Status);
            Job.Start_time = new Point(Convert.ToInt32(aj_nud_from_h.Value), Convert.ToInt32(aj_nud_from_minute.Value));
            Job.End_time = new Point(Convert.ToInt32(aj_nup_to_h.Value), Convert.ToInt32(aj_nup_to_minute.Value));

            if (job_update != null)
            {
                job_update(this, new EventArgs());
            }
        }

        private void aj_cb_done_CheckedChanged(object sender, EventArgs e)
        {
            if(aj_cb_done.Checked)
            {
                aj_cb_status.SelectedIndex = 0;
            }
            
        }

        private void aj_cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(aj_cb_status.SelectedItem.ToString() == "done")
            {
                aj_cb_done.Checked = true;
                return;
            }
            aj_cb_done.Checked = false;
            
        }
    }
}
