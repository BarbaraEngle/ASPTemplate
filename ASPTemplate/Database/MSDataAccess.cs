using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPTemplate
{
    public class MSDataAccess
    {
        private string _connectionString;

        public MSDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetPersonName(int personId)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cn.Open();

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"Select FullName FROM Person WHERE PersonID = {personId}";

                    string result = cmd.ExecuteScalar().ToString();

                    return result;
                }

            }
        }
    }
}