using System;
using System.Collections.Generic;
using System.Text;

namespace ESportDanmark.Entities
{
    public class Person
    {
        private int id;
        private string name;
        private int telephone;
        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        
    }
}
