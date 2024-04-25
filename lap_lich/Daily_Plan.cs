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
    public partial class Daily_Plan : Form
    {
        private DateTime date;
        private plan_data plan_job;

        private int temp = 0;

        public Daily_Plan(DateTime dateTime, plan_data job)
        {
            InitializeComponent();

            this.date = dateTime;
            this.plan_job = job;

            dp_dtp_day.Value = dateTime;
            show_job_by_day(dateTime);

        }

        void show_job_by_day(DateTime date)
        {
            dp_p_show_job.Controls.Clear();
            
            if (plan_job != null && plan_job.List_job != null)
            {
                int y = 0;
                foreach (var j in plan_job.List_job)
                {
                    if (static_class.is_euqal_day(date, j.Date))
                    {
                        A_job a_Job = new A_job(j);
                        a_Job.Job_Update += A_Job_Job_Update;
                        a_Job.Job_Delete += A_Job_Job_Delete;
                        a_Job.Location = new Point(0, y);
                        temp = y;
                        y += 84;
                        
                        dp_p_show_job.Controls.Add(a_Job);
                        
                    }

                }
            }
        }

        private void dp_dtp_day_ValueChanged(object sender, EventArgs e)
        {
            show_job_by_day((sender as DateTimePicker).Value);
        }

        private void dp_bt_pre_Click(object sender, EventArgs e)
        {
            dp_dtp_day.Value = dp_dtp_day.Value.AddDays(-1);
        }

        private void dp_bt_next_Click(object sender, EventArgs e)
        {
            dp_dtp_day.Value = dp_dtp_day.Value.AddDays(+1);

        }

        private void ms_today_Click(object sender, EventArgs e)
        {
            dp_dtp_day.Value = DateTime.Now;
        }

        private void A_Job_Job_Delete(object? sender, EventArgs e)
        {
            A_job job_control = sender as A_job;
            plain_item a_job = job_control.Job;

            dp_p_show_job.Controls.Remove(job_control);
            plan_job.List_job.Remove(a_job);
        }

        private void A_Job_Job_Update(object? sender, EventArgs e)
        {
            if(sender is plain_item)
            {
                (sender as plain_item).Date = dp_dtp_day.Value;
            }
            
        }

        private void Daily_Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            var ok = MessageBox.Show("save ?", "save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ok != DialogResult.OK)
            {
                e.Cancel = true;
            }
            */

        }

        private void ms_add_job_Click(object sender, EventArgs e)
        {
            
            plain_item pi = new plain_item();
            pi.Date = dp_dtp_day.Value;
            pi.Status = "doing";
            pi.Title = "title: " + dp_dtp_day.Value;

            plan_job.List_job.Add(pi);
            A_job a_Job = new A_job(pi);
            a_Job.Job_Update += A_Job_Job_Update;
            a_Job.Job_Delete += A_Job_Job_Delete;
            temp += 85;
            a_Job.Location = new Point(0, temp);
            

            dp_p_show_job.Controls.Add(a_Job);
            
        }
    }
}
