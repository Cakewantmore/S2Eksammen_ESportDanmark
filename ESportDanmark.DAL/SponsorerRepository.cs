using ESportDanmark.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESportDanmark.DAL
{
    public class SponsorerRepository : BaseRepository
    {
        public List<Sponsorer> GetSponsorer()
        {
            List<Sponsorer> Result = new List<Sponsorer>();
            string selectQuery = "SELECT * FROM Sponsorer";

            DataSet resultSet = Execute(selectQuery);

            DataTable dataTable = resultSet.Tables[0];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Sponsorer tableValue = new Sponsorer();
                int id = (int)dataRow["Id"];

                string companyName = (string)dataRow["Company_Name"];
                string branch = (string)dataRow["Branch"];
                int playerId = (int)dataRow["PlayerID"];
                string playerName = (string)dataRow["PlayerName"];
                double udgift = (double)dataRow["Udgift"];
                tableValue.Id = id;
                tableValue.CompanyName = companyName;
                tableValue.Branch = branch;
                tableValue.PlayerId = playerId;
                tableValue.PlayerName = playerName;
                tableValue.Udgift = udgift;
                Result.Add(tableValue);

            }
            return Result;
        }
    }
}
