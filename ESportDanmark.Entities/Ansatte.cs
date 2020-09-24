using System;
using System.Collections.Generic;
using System.Text;

namespace ESportDanmark.Entities
{
    public class Ansatte : Person
    {
        
        private double pay;
        private string jobtype;
        private int refereeLvl;

        
        public double Pay { get => pay; set => pay = value; }
        public string Jobtype { get => jobtype; set => jobtype = value; }
        public int RefereeLvl { get => refereeLvl; set => refereeLvl = value; }
    }
}
