using System;
using System.Collections.Generic;
using System.Text;

namespace ESportDanmark.Entities
{
    public class Turneringer : Person
    {
        private string tournamentName;
        private int playerId;
        private string playerName;
        private int playerTelephone;
        private int refereeId;
        private string refereeName;
        private int refereeTelephone;
        private int refereeLvl;

        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public int PlayerTelephone { get => playerTelephone; set => playerTelephone = value; }
        public int RefereeId { get => refereeId; set => refereeId = value; }
        public string RefereeName { get => refereeName; set => refereeName = value; }
        public int RefereeTelephone { get => refereeTelephone; set => refereeTelephone = value; }
        public int RefereeLvl { get => refereeLvl; set => refereeLvl = value; }

    }
}
