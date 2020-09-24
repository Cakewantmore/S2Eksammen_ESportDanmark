using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ESportDanmark.DAL
{
    public class BaseRepository
    {
        private string connectionString = "Data Source=CV-BB-5910;Initial Catalog=ESportDanmark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        

        public DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;

        }
        public Boolean checkNumberExists(int telephone)
        {
            bool result = false;
            string selectQuery = $"SELECT FROM Spillere WHERE Telephone ={ telephone}";
            DataSet checkNumber = Execute(selectQuery);
            if(checkNumber == null)
            {
                selectQuery = $"SELECT FROM Ansatte WHERE Telephone ={telephone}";
                checkNumber = Execute(selectQuery);
                if(checkNumber != null)
                {
                    result = true;
                }

            }
            else
            {
                result = true;
            }
            return result;
                
        }
        
    }
}
