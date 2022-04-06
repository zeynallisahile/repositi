using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Shop
    {
        private List<Order> _orders;
        public Shop()
        {
            _orders = new List<Order>();
        }     
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void GetOrdersAvg()
        {

        }

        public double TotalAlmount(double sum)
        {
            sum = 0;
            foreach (var item in _orders)
            {
                sum = sum + item.TotalAmount;
            }
            sum /=_orders.Count;
            return sum;
        }
        public void GetOrdersAvg(DateTime dateTime)
        {
            List<Order> filterPrice = new List<Order>();           
             
        }

        public void RemoveOrderByNo(int no)
        {            
            _orders.Remove(_orders.Find(x => x.No == no));
        }

        public List<Order>FilterOrderByPrice(int min,int max)
        {
            List<Order> filterOrderByPrice = new List<Order>();
            var result = _orders.Find(x => x.TotalAmount >= min && x.TotalAmount <= max);
            return filterOrderByPrice;
        }
    }
}
