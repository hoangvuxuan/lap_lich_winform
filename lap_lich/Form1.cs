using lap_lich.all_class;
using Microsoft.Win32;
using System.Xml.Serialization;
using static lap_lich.all_class.plain_item;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lap_lich
{
    public partial class Form1 : Form
    {
        private List<List<Button>> matrix;

        private List<string> day_of_week = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private plan_data plan_job;

        private List<plain_item> today_job;

        private string file_path = "data.xml";

        public Form1()
        {
            InitializeComponent();
            show_matrix();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\LapLich");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("LapLich", Application.StartupPath + "\\lap_lich.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            try
            {
                plan_job = static_class.deserialize_xml(file_path) as plan_data;
                today_job = new List<plain_item>();
                set_today_job();
            }
            catch
            {
                MessageBox.Show("fuck");
            }

        }

        public void set_today_job()
        {
            foreach(var i in plan_job.List_job)
            {
                if(static_class.is_euqal_day(i.Date, DateTime.Now))
                {
                    today_job.Add(i);
                }
            }
        }


        public void show_matrix()
        {
            //tao ma tran luu ngay
            matrix = new List<List<Button>>();

            Button old_bt = new Button()
            {
                Width = 95,
                Height = 59,
                Location = new Point(0, 0)
            };
            old_bt.Click += Bt_show_dp_from;


            for (int i = 0; i <= 5; i++)
            {
                //them hang
                matrix.Add(new List<Button>());

                //them gia tri dau tien cua hang
                matrix[i].Add(old_bt);

                p_matrix.Controls.Add(old_bt);
                for (int j = 0; j < 6; j++)
                {
                    Button new_bt = new Button()
                    {
                        Width = 95,
                        Height = 59,
                        Location = new Point(old_bt.Location.X + 95 + 6, old_bt.Location.Y)
                    };
                    new_bt.Click += Bt_show_dp_from;

                    p_matrix.Controls.Add(new_bt);

                    //them cac gia tri sau
                    matrix[i].Add(new_bt);

                    old_bt = new_bt;


                }

                old_bt = new Button()
                {
                    Width = 95,
                    Height = 59,
                    Location = new Point(0, old_bt.Location.Y + 59 + 6)
                };
                old_bt.Click += Bt_show_dp_from;

            }

            add_num_to_matrix(dtp_day.Value);
        }


        private int day_of_month(DateTime dt)
        {
            switch (dt.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((dt.Year % 4 == 0 && dt.Year % 100 != 0) || dt.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }



        public void add_num_to_matrix(DateTime date)
        {
            DateTime use_day = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= day_of_month(date); i++)
            {
                int colum = day_of_week.IndexOf(use_day.DayOfWeek.ToString());

                matrix[line][colum].Click += Bt_Click;

                matrix[line][colum].Text = i.ToString();

                if (static_class.is_euqal_day(use_day, DateTime.Now))
                {
                    matrix[line][colum].BackColor = Color.GreenYellow;
                }
                if (static_class.is_euqal_day(use_day, dtp_day.Value))
                {
                    matrix[line][colum].BackColor = Color.HotPink;

                }

                if (colum >= 6)
                {
                    line++;
                }
                use_day = use_day.AddDays(1);
            }

        }

        private void Bt_Click(object? sender, EventArgs e)
        {
            int day = Convert.ToInt32((sender as Button).Text);
            dtp_day.Value = new DateTime(dtp_day.Value.Year, dtp_day.Value.Month, day);

        }

        private void Bt_show_dp_from(object? sender, EventArgs e)
        {
            try
            {
                int day = Convert.ToInt32((sender as Button).Text);
                Daily_Plan daily_Plan = new Daily_Plan(new DateTime(dtp_day.Value.Year, dtp_day.Value.Month, day), plan_job);
                daily_Plan.ShowDialog();
            }
            catch { }



        }

        void clear_matrix()
        {

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button bt = matrix[i][j];
                    bt.Text = "";
                    bt.BackColor = Color.White;
                }
            }
        }

        private void dtp_day_ValueChanged(object sender, EventArgs e)
        {

            clear_matrix();
            add_num_to_matrix(dtp_day.Value);
        }


        private void bt_today_Click(object sender, EventArgs e)
        {
            dtp_day.Value = DateTime.Now;
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {

            try
            {
                dtp_day.Value = dtp_day.Value.AddMonths(-1);
                dtp_day.Value = new DateTime(dtp_day.Value.Year, dtp_day.Value.Month, 1);
            }
            catch (Exception ex)
            {

                var month = dtp_day.Value.Month - 1;
                var year = dtp_day.Value.Year;

                dtp_day.Value = new DateTime(year, month, 1);


            }

        }

        private void bt_next_Click(object sender, EventArgs e)
        {

            try
            {
                dtp_day.Value = dtp_day.Value.AddMonths(1);
                dtp_day.Value = new DateTime(dtp_day.Value.Year, dtp_day.Value.Month, 1);
            }
            catch (Exception ex)
            {

                var month = dtp_day.Value.Month + 1;
                var year = dtp_day.Value.Year;

                dtp_day.Value = new DateTime(year, month, 1);


            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            static_class.serialize_to_xml(plan_job, "data.xml");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.AddMinutes(-10);
            foreach(var i in today_job)
            {
                if(i.Start_time.X == DateTime.Now.Hour && i.Start_time.Y == DateTime.Now.Minute)
                {
                    notifyIcon1.ShowBalloonTip(60000, "lich cong viec", i.Job, ToolTipIcon.Info);
                }

                if(i.Start_time.X == dt.Hour && i.Start_time.Y == dt.Minute)
                {
                    notifyIcon1.ShowBalloonTip(60000, "lich cong viec", "con 10 phut: " + i.Job, ToolTipIcon.Info);
                }
            }
                      
        }

    }
}
