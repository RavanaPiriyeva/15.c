using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Hotel
    {
        private Room[] _rooms= new Room[0];
        public string Name { get; set; }
        private Room[] Rooms { get { return _rooms; } }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length-1] = room;
        }
        public void MakeReservation(int? roomId)
        {
          
           if (roomId != null) 
           { 
            {
                  
                bool check = true;
                foreach(var item in _rooms) 
                {
                    if (roomId == item.Id)
                    {
                        if (item.IsAvailable == false)
                        {
                            throw new NotAvailableException("otaqda yasamaq olmur");
                        }
                        else 
                        {
                            Console.WriteLine(item.ToString());
                                check = false;
                        }
                    }
                }
                    if (check)
                    {
                        throw new NotAvailableException("Bele otaq yoxdur");
                        
                    }
             }
           }
            else 
            {
                throw new NotAvailableException("Room Id daxil etmemisiz");
            }
        }
//- Rooms array - içində Room obyektləri saxlayır və private-dır.
//- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.
//- MakeReservation() - Parametr olaraq nullable int tipindən bir roomId qəbul edir əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda göndərilən roomId-li otaq tapılır və IsAvailable dəyəri yoxlanılır əgər IsAvailable dəyəri  false-dusa geriyə yuxarıda yaratdığınız NotAvailableException qaytarılır əgər true-dursa həmin room-un IsAvailable dəyəri true olur.

    }
}
