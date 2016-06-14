using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PersonLibrary {
    public class Employee {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetEmployees(int pageIdx, int pageSize, out int totalRows) {
            List<Employee> lst = new List<Employee>();
            string connectString = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;
            //using block ensures that all resources will be closed and disposed when the code exits.
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection con = new SqlConnection(connectString)) {                
                cmd.Connection = con;
                cmd.CommandText = "getEmpBy_PageIdx_and_PageSize";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pageIndex", pageIdx);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);


                //add the output parameter
                SqlParameter outParm = new SqlParameter();
                outParm.ParameterName = "@totalRows";
                outParm.SqlDbType = System.Data.SqlDbType.Int;
                outParm.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outParm);

                try {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        lst.Add(new Employee {
                            EmployeeId = Convert.ToInt32(reader[0]),
                            Name = reader[1].ToString(),                            
                            Gender = reader[2].ToString(),
                            Salary = Convert.ToInt32(reader[3])
                        });
                    }
                    reader.Close();
                }
                catch(Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }

            //* very important to retrieve output parameter after closing the DataReader
            totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
            return lst;
        }
    }
}
