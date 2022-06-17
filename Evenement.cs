using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Evenement
    {
        public int id;
        public DateTime dateEvent;
        public string nameEvent;
        public string descEvent;

        //Constructor
        public Evenement(int id, DateTime dateEvent, string nameEvent, string descEvent)
        {
            this.id = id;
            this.dateEvent = dateEvent;
            this.nameEvent = nameEvent;
            this.descEvent = descEvent;
        }

        //Getters
        public int getId()
        {
            return id;
        }
        public DateTime GetDateEvent()
        {
            return dateEvent;
        }
        public string GetNameEvent()
        {
            return nameEvent;
        }
        public string GetDescEvent()
        {
            return descEvent;
        }

        //To String
        public override string ToString()
        {
            return "Id: " + id + " Date: " + dateEvent + " Name: " + nameEvent + " Desc: " + descEvent;
        }
    }
}
