using System;
using System.Collections.Generic;
using System.Text;

namespace ESportDanmark.Entities
{
    public class Sponsorer : Person
    {
        private string companyName;
        private string branch;
        private int playerId;
        private string playerName;
        private double udgift;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Branch { get => branch; set => branch = value; }
        public int PlayerId { get => Id; set => playerId = value; }
        public string PlayerName { get => Name; set => playerName = value; }
        public double Udgift { get => udgift; set => udgift = value; }
    }
}
