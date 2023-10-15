using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class CustomEventHandler
    {
        SortedList<string, CustomEvent> customEvents;
        static StringBuilder log;

        static CustomEventHandler() {
            log = new StringBuilder();
            log.AppendLine(DateTime.Now.ToString() + " CustomEventHandler initialized.");
        }
        public CustomEventHandler()
        {
            customEvents = new SortedList<string, CustomEvent>();
        }

        public SortedList<string, CustomEvent> CustomEvents
        {
            get
            {
                return customEvents;
            }
        }

        public StringBuilder Log
        {
            get
            {
                return log;
            }
        }

        public string HandleEvent(EventDelegate someEvent, string name, string type, string location, DateTime date, double price)
        {
            string result = someEvent(name, type, location, date, price);

            return result;
        }


        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            customEvents.Add(name, newEvent);

            log.AppendLine(DateTime.Now.ToString() + $" Added event: {name}");
            return $"Current number of events in the collection: {customEvents.Count}";
        }

        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (var pair in customEvents)
            {
                var e = pair.Value;
                if (e.Name == name ||
                    e.Type == type ||
                    e.Location == location ||
                    e.Date == date ||
                    e.Price == price)
                {
                    log.AppendLine(DateTime.Now.ToString() + $" Searched event: {e.Name}");
                    return $"Searched Event Name: {e.Name}, Type: {e.Type}, Location: {e.Location}, Date: {e.Date}, Price: {e.Price}";
                }
            }

            log.AppendLine(DateTime.Now.ToString() + " No matching event found.");
            return "No matching event found.";
        }

        // Update an event based on the provided name and change the event information.
        public string UpdateEvent(string name, string type, string location, DateTime date, double price)
        {
            if (customEvents.ContainsKey(name))
            {
                CustomEvent oldEvent = customEvents[name];
                log.AppendLine(DateTime.Now.ToString() + $" Updated event: {name}");

                // Return the information of the old event.
                string oldEventData = $"Updated Event Name: {oldEvent.Name}, Type: {oldEvent.Type}, Location: {oldEvent.Location}, Date: {oldEvent.Date}, Price: {oldEvent.Price}";

                // Update the event's information.
                customEvents[name].Type = type;
                customEvents[name].Location = location;
                customEvents[name].Date = date;
                customEvents[name].Price = price;

                return oldEventData;
            }
            else
            {
                log.AppendLine(DateTime.Now.ToString() + $" Event not found for updating: {name}");
                return $"Event not found for updating: {name}";
            }
        }

        // Delete an event based on provided attributes and return the information of the deleted event.
        public string DeleteEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (var pair in customEvents)
            {
                var e = pair.Value;
                if (e.Name == name ||
                    e.Type == type ||
                    e.Location == location ||
                    e.Date == date ||
                    e.Price == price)
                {
                    customEvents.Remove(e.Name);
                    log.AppendLine(DateTime.Now.ToString() + $" Deleted event: {e.Name}");
                    return $"Deleted Event Name: {e.Name}, Type: {e.Type}, Location: {e.Location}, Date: {e.Date}, Price: {e.Price}";
                }
            }

            log.AppendLine(DateTime.Now.ToString() + "No matching event found for deletion.");
            return "No matching event found for deletion.";
        }
    }
}