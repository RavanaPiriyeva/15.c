using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Room
    {
        public Room(string name , double price , int personCapasity)
        {
            this.Name=name;
            this.PersonCapasity=personCapasity;
            this.Price=price;
            _id++;
            Id = _id;
        }
        static int _id;
        public int Id { get; set; }
        public string Name;
        public double Price;
        public int PersonCapasity;
        public bool IsAvailable = true;
        public string ShowInfo()
        {
           return $"Id:{Id}    Name:{Name}    Price:{Price}    Person Capasity:{PersonCapasity}    Is Available:{IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

        //        - Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda avtomatik bir vahid artacaq.
        //- Name
        //- Price
        //- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
        //- IsAvailable - otağın rezervasiya olunub olunmadığını göstərir, default olaraq true olmalıdır.
        //- ShowInfo() - Otağın bütün məlumatlarını göstərir

        //ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.

        //ps: Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz
    }
}
