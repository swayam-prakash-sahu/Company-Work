using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class dataTable_Set
    {
        public static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            DataRow dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "Subhendu";
            dr["Age"] = 22;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "SPS";
            dr[2] = 22;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "aryan";
            dr[2] = 21;
            dt.Rows.Add(dr);


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Id", typeof(int));
            dt1.Columns.Add("Name", typeof(string));
            dt1.Columns.Add("Age", typeof(int));

            DataRow dr1 = dt1.NewRow();
            dr1["Id"] = 1;
            dr1["Name"] = "Subhendu";
            dr1["Age"] = 22;
            dt1.Rows.Add(dr1);

            dr1 = dt1.NewRow();
            dr1[0] = 2;
            dr1[1] = "Swayam";
            dr1[2] = 22;
            dt1.Rows.Add(dr1);


            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                Console.WriteLine(id);
                string name = Convert.ToString(row["Name"]);
                Console.WriteLine(name);
                int age = Convert.ToInt32(row["Age"]);
                Console.WriteLine(age);
            }


            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);
            dataSet.Tables.Add(dt1);
            Console.Read();
        }
    }
}
