using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Evenement
    {
        public DateTime dateEvent;
        public string nameEvent;
        public string descEvent;

        //Constructor
        public Evenement(DateTime dateEvent, string nameEvent, string descEvent)
        {
            this.dateEvent = dateEvent;
            this.nameEvent = nameEvent;
            this.descEvent = descEvent;
        }

        //Getters
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
            return "Date: " + dateEvent.ToString("D") + "\nName: " + nameEvent + "\nDescription: " + descEvent;
        }
    }
}
