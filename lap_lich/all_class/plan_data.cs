using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace lap_lich.all_class
{
    [Serializable]

    public class plan_data
    {
        private List<plain_item> list_job;

        public List<plain_item> List_job { get => list_job; set => list_job = value; }
    }
}
