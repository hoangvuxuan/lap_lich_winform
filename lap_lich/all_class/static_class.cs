using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lap_lich.all_class
{
    public static class static_class
    {
        public static bool is_euqal_day(DateTime dt1, DateTime dt2)
        {
            if (dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day)
            {
                return true;
            }
            return false;
        }

        public static object deserialize_xml(string file_padth)
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
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }


        public static void  serialize_to_xml(object obj, string file_padth)
        {
            if(File.Exists(file_padth))
            {
                File.Delete(file_padth);
            }
            FileStream fs = new FileStream(file_padth, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(plan_data));


            sr.Serialize(fs, obj);
            fs.Close();

        }


    }
}
