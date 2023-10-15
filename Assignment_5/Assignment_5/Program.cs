using System;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomEventHandler customEventHandler = new CustomEventHandler();

            EventDelegate delegateAdd = new EventDelegate(customEventHandler.AddEvent);
            EventDelegate delegateSearch = new EventDelegate(customEventHandler.SearchEvent);
            EventDelegate delegateUpdate = new EventDelegate(customEventHandler.UpdateEvent);
            EventDelegate delegateDelete = new EventDelegate(customEventHandler.DeleteEvent);

            string addResult2 = customEventHandler.HandleEvent(delegateAdd, "Event2", "Type2", "Location2", new DateTime(2023, 10, 15, 14, 30, 0), 200.0);
            string addResult1 = customEventHandler.HandleEvent(delegateAdd, "Event1", "Type1", "Location1", new DateTime(2023, 10, 16, 10, 0, 0), 100.0);
            string addResult3 = customEventHandler.HandleEvent(delegateAdd, "Event3", "Type3", "Location3", new DateTime(2023, 10, 17, 20, 55, 0), 350.0);
            Console.WriteLine(addResult3);

            string searchResult = customEventHandler.HandleEvent(customEventHandler.SearchEvent, "Event3", null, null, DateTime.Now, 0.0);
            Console.WriteLine(searchResult);

            string updateResult = customEventHandler.HandleEvent(customEventHandler.UpdateEvent, "Event2", "Type999", "Location999", DateTime.Now.AddHours(1), 200.0);
            Console.WriteLine(updateResult);

            string deleteResult = customEventHandler.HandleEvent(customEventHandler.DeleteEvent, "Event1", null, null, DateTime.Now.AddHours(2), 0.0);
            Console.WriteLine(deleteResult);

            Console.WriteLine();
            Console.WriteLine("Log data: ");
            Console.WriteLine(customEventHandler.Log);

            Console.WriteLine("List of events after updates");
            foreach (var item in customEventHandler.CustomEvents)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }
}
