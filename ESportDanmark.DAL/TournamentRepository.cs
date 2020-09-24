using ESportDanmark.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace ESportDanmark.DAL
{
    public class TournamentRepository : BaseRepository
    {
    Spillere spillere = new Spillere();
        Ansatte ansatte = new Ansatte();
        public List<Turneringer> GetTurneringer()
        {
            List<Turneringer> Result = new List<Turneringer>();
            string selectQuery = "SELECT * FROM Turneringer";

            DataSet resultSet = Execute(selectQuery);

            DataTable dataTable = resultSet.Tables[0];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Turneringer tableValue = new Turneringer();
                int id = (int)dataRow["Id"];

                string tournamentName = (string)dataRow["tournamentName"];
                //int playerID = spillere.Id;//(int)dataRow["player_ID"];
                //string playerName = spillere.Name;
                //int playertelephone = spillere.Telephone; //(int)dataRow["player_telephone"];
                //int refereeId = ansatte.Id;//(int)dataRow["referee_ID"];
                //string refereeName = ansatte.Name; //(string)dataRow["referee_name"];
                //int refereetelephone = ansatte. //(int)dataRow["referee_telephone"];
                tableValue.Id = id;
                tableValue.TournamentName = tournamentName;
                //tableValue.PlayerId = playerID;
                //tableValue.PlayerName = playerName;
                //tableValue.PlayerTelephone = playertelephone;
                //tableValue.RefereeId = refereeId;
                //tableValue.RefereeName = refereeName;
                //tableValue.RefereeTelephone = refereetelephone;
                Result.Add(tableValue);

            }
            return Result;
        }
    }
}

