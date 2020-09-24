using ESportDanmark.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using Xceed.Wpf.Toolkit;

namespace ESportDanmark.DAL
{

    public class SpillereRepository : BaseRepository
    {
        
        public List<Spillere> GetSpillere()
        {
            List<Spillere> Result = new List<Spillere>();
            string selectQuery = "SELECT * FROM Spillere";

            DataSet resultSet = Execute(selectQuery);

            DataTable dataTable = resultSet.Tables[0];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Spillere tableValue = new Spillere();
                int id = (int)dataRow["Id"];
                string name = (string)dataRow["Name"];
                string summonerName = (string)dataRow["Summoner_Name"];
                string rank = (string)dataRow["Rank"];
                int telephone = (int)dataRow["Telephone"];
                string tournamentType = (string)dataRow["TournamentType"];
                tableValue.Id = id;
                tableValue.Name = name;
                tableValue.SummonerName = summonerName;
                tableValue.Rank = rank;
                tableValue.Telephone = telephone;
                tableValue.TournamentType = tournamentType;
                Result.Add(tableValue);

            }
            return Result;
        }

        public void deleteRow(Spillere spiller)
        {
            
            
            string deleteRowQuery = $"DELETE FROM Spillere WHERE Id = {spiller.Id}";
        }
        public void addNew(Spillere spillere)
        {
            string addNewQuery = $"INSERT INTO Spillere(Name, Summoner_Name, Rank, Telephone) VALUES('{spillere.Name}','{spillere.SummonerName}','{spillere.Rank}','{spillere.Telephone}','{spillere.TournamentType}')";
            try
            {
                Execute(addNewQuery);
            }
            catch(Exception EX)
            {
                //MessageBox.Show("fejl" + EX.Message);
            }
        }
       // public void api()
       // {
       //     try
       //     {
       //         string json = new WebClient().DownloadString(@$"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key=RGAPI-f2f2f546-5d8c-4d7d-b4f4-67e01249f7b4");
       //     }
       //
       //
       //     catch (Exception EX)
       //     {
       //
       //     }
       // }
    }
    
}
