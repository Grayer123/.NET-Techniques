using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PersonLibrary
{
    public class PersonLong {
        public int Person_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public static string Dates { get; set; }

        public static List<PersonLong> GetPersonLong(int age) {
            string connectString = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;
            List<PersonLong> lst = new List<PersonLong>();
            //using block ensures that all resources will be closed and disposed when the code exits.
            using (SqlConnection con = new SqlConnection(connectString)) {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "getPersonLongRecords";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@age", age);

                //add the output parameter
                SqlParameter outParm = new SqlParameter();
                outParm.ParameterName = "@curDate";
                outParm.SqlDbType = System.Data.SqlDbType.Date;
                outParm.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outParm);

                try {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();                                       
                    while (reader.Read()) {
                        lst.Add(new PersonLong {
                            Person_Id = Convert.ToInt32(reader[0]),
                            FirstName = reader[1].ToString(),
                            LastName = reader[2].ToString(),
                            City = reader[3].ToString(),
                            PhoneNumber = reader[4].ToString(),
                            Age = Convert.ToInt32(reader[5])
                        });
                    }                    
                    reader.Close();
                    if (outParm.Value != null) {
                        PersonLong.Dates = Convert.ToDateTime(outParm.SqlValue.ToString()).ToShortDateString();
                        //PersonLong.Dates = outParm.Value.ToString();
                    }
                }
                catch {
                    //Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }
            return lst;
        }
    }
}
