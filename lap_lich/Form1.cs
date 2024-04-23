using lap_lich.all_class;
using System.Xml.Serialization;
using static lap_lich.all_class.plain_item;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lap_lich
{
    public partial class Form1 : Form
    {
        private List<List<Button>> matrix;

        private List<string> day_of_week = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };



        private string file_path = "data.xml";

        public Form1()
        {
            InitializeComponent();
            show_matrix();
            try
            {
                deserialize_xml(file_path);
            }
            catch
            {
            }

        }

        //demo


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

        private bool is_euqal_day(DateTime dt1, DateTime dt2)
        {
            if (dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day)
            {
                return true;
            }
            return false;
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

                if (is_euqal_day(use_day, DateTime.Now))
                {
                    matrix[line][colum].BackColor = Color.GreenYellow;
                }
                if (is_euqal_day(use_day, dtp_day.Value))
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


        private object deserialize_xml(string file_padth)
        {
            FileStream fs = new FileStream(file_padth, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(plan_data));

                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception ex)
            {
                fs.Close();
                throw ex;
            }

        }


        private void serialize_to_xml(object obj, string file_padth)
        {
            FileStream fs = new FileStream(file_padth, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(plan_data));
  

            sr.Serialize(fs, obj);
            fs.Close();
            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //serialize_to_xml(plan_job, file_path);
        }


        private plan_data plan_job = new plan_data();
        void set_default()
        {

            plan_job.List_job = new List<plain_item>();
            plan_job.List_job.Add(new plain_item()
            {
                Title = "cau troi khan phajt",
                Date = DateTime.Now,
                Start_time = new Point(4, 0),
                End_time = new Point(12, 12),
                Job = "2222090",
                Status = plain_item.list_status[(int)e_plan_item.doing]
            });

        }
        private void bt_thursday_Click(object sender, EventArgs e)
        {

            set_default();
            serialize_to_xml(plan_job, file_path);
             
        }
    }
}
