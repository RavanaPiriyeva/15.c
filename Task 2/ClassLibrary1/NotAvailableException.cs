using System;

namespace ClassLibrary1
{
    public class NotAvailableException:Exception
    {
        public  NotAvailableException(string str):base(str)
        {

        }
    }
}
