using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class EvenementDto
    {
        public static List<Evenement> getEvenements()
        {
            string path = @"..\..\..\Calendar\Events.json";
            string strEvent = File.ReadAllText(path);
            string[] strEventSplit = strEvent.Split(';');
            List<Evenement> evenementList = new List<Evenement>();

            foreach (string str in strEventSplit)
            {
                Evenement evenementObj = JsonConvert.DeserializeObject<Evenement>(str);
                evenementList.Add(evenementObj);
            }
            return evenementList;
        }

        public static List<Evenement> GetEvenementsPerDate(DateTime date)
        {

            string path = @"..\..\..\Calendar\Events.json";
            string strEvent = File.ReadAllText(path);
            string[] strEventSplit = strEvent.Split(';');
            List<Evenement> eventListPerDate = new List<Evenement>();
            foreach (string str in strEventSplit)
            {
                Evenement evenementObj = JsonConvert.DeserializeObject<Evenement>(str);
                if (evenementObj.dateEvent == date)
                {
                    eventListPerDate.Add(evenementObj);
                }
            }
            return eventListPerDate;
        }

        public static void addEvenements(DateTime selectedDate, string name, string desc)
        {
            string path = @"..\..\..\Calendar\Events.json";
            string strEvent = File.ReadAllText(path);
            string[] strEventSplit = strEvent.Split(';');
            List<Evenement> evenementList = new List<Evenement>();
            foreach (string str in strEventSplit)
            {
                Evenement evenementObj = JsonConvert.DeserializeObject<Evenement>(str);
                evenementList.Add(evenementObj);
            }
            //Return last element
            Evenement lastEventID = evenementList.Last();
            Debug.WriteLine(lastEventID);
            Evenement newEvenemntObj = new Evenement(lastEventID.id + 1, selectedDate, name, desc);
            string json = JsonConvert.SerializeObject(newEvenemntObj);
            Debug.WriteLine(json);
            File.AppendAllText(path, ";" + json + Environment.NewLine);
        }

        //Delete event from JSON file
        public static void deleteEvenement(int idEvent)
        {
            string path = @"..\..\..\Calendar\Events.json";
            string strEvent = File.ReadAllText(path);
            string[] strEventSplit = strEvent.Split(';');
            List<Evenement> eventList = new List<Evenement>();
            foreach (string str in strEventSplit)
            {
                Evenement eventObj = JsonConvert.DeserializeObject<Evenement>(str);
                eventList.Add(eventObj);
            }
            eventList.RemoveAll(x => x.id == idEvent);
            string json = JsonConvert.SerializeObject(eventList);
            File.WriteAllText(path, json);
        }
    }
}