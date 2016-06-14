using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PersonEntities;

namespace PersonLibrary {
    public class PersonShort {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }

        public static List<PersonShortEntity> GetPersonShort(int age) {
            List<PersonLongEntity> lstLong = PersonLong.GetPersonLong(age);
            List<PersonShortEntity> lstShort = new List<PersonShortEntity>();
            foreach (var item in lstLong) {
                lstShort.Add(new PersonShortEntity {
                    Id = item.Person_Id,
                    Name = item.FirstName + "," + item.LastName,
                    Age = item.Age
                });
            }
            return lstShort;
        }

        public static void SaveToPersonShort(List<PersonShortEntity> sp) {
            string connectString = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;
            //using block ensures that all resources will be closed and disposed when the code exits.
            using (SqlConnection con = new SqlConnection(connectString)) {
                              
                try {
                    con.Open();
                    foreach (var item in sp) {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "insertToPersonShort";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fullName", item.Name);
                        cmd.Parameters.AddWithValue("@age", item.Age);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch  {
                    //Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }
        }
    }
}
