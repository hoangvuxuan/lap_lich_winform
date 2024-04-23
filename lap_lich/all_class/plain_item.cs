using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_lich.all_class
{
    public class plain_item
    {
        private DateTime _date;

        private string title;
        private string job;
        private Point start_time;
        private Point end_time;
        private string status;

        public static List<string> list_status = new List<string>() { "done", "doing", "coming", "missed" };
        public enum e_plan_item
        {
            done,
            doing,
            coming,
            missed
        }
        public string Title { get => title; set => title = value; }
        public string Job { get => job; set => job = value; }
        public Point Start_time { get => start_time; set => start_time = value; }
        public Point End_time { get => end_time; set => end_time = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
