using System;
using System.Collections.Generic;
using System.Text;

namespace ESportDanmark.Entities
{
    public class Spillere : Person
    {

        private string summonerName;
        private string rank;
        private string tournamentType;

        public string SummonerName { get => summonerName; set => summonerName = value; }
        public string Rank { get => rank; set => rank = value; }
        public string TournamentType { get => tournamentType; set => tournamentType = value; }
    }
}
