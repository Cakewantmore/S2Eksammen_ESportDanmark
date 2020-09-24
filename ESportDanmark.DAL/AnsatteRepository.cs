using ESportDanmark.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace ESportDanmark.DAL
{
    public class AnsatteRepository : BaseRepository
    {
        public List<Ansatte> GetAnsatte()
        {
            List<Ansatte> Result = new List<Ansatte>();
            string selectQuery = "SELECT * FROM Ansatte";

            DataSet resultSet = Execute(selectQuery);

            DataTable dataTable = resultSet.Tables[0];

            foreach( DataRow dataRow in dataTable.Rows)
            {
                Ansatte tableValue = new Ansatte();
                int id = (int)dataRow["Id"];
                string name = (string)dataRow["Name"];
                int telephone = (int)dataRow["Telephone"];
                double pay = (double)dataRow["Pay"];
                string jobtype = (string)dataRow["Jobtype"];
                int refereeLvl = (int)dataRow["refereeLvl"];
                tableValue.Name = name;
                tableValue.Telephone = telephone;

                tableValue.Pay = pay;
                tableValue.Jobtype = jobtype;
                tableValue.RefereeLvl = refereeLvl;
                Result.Add(tableValue);

            }
            return Result;
        }
    }
}
