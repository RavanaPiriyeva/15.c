using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "aaaa";
            double price = 150;
            int personCapasity = 3;
            Room room1 = new Room(name, price, personCapasity);
            room1.Name = name;
            room1.Price = price;
            room1.PersonCapasity = personCapasity;
            room1.IsAvailable = false  ;


            string name2 = "bbbb";
            double price2 = 200;
            int personCapasity2 = 4;
            Room room2 = new Room(name2, price2, personCapasity2);
            room2.Name = name2;
            room2.Price = price2;
            room2.PersonCapasity = personCapasity2;

            Hotel hotel = new Hotel();
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            try
            {
                hotel.MakeReservation(3);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
