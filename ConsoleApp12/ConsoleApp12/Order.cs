using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Order
    {
        private static int _no;
        public int No { get;}
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }

        private static DateTime _createdAt;
        public DateTime CreatedAt { get;}
        public Order()
        {
            _no++;
            No = _no;
            _createdAt = DateTime.UtcNow.Date;
            CreatedAt = _createdAt;
        }
    }
}
