using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ConsoleApp
{
    class Program
    {public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 12, 30, 80, 56, 94, 70 };
            string[] nameArray = { "alok", "Rajat", "Upasana", "dev", "Priya", "Shivam", "Harsh" };
            /*foreach(var item in numArray)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }*/
            //Linq query
            /*var result = from data in numArray
                         where data % 2 == 0
                         select data;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            /*int dataToSearch = 12;
            var result = from data in numArray
                         where data == 12 //or dataToSearch
                         select data;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            /*String dataToSearch = "";
            var result = from data in nameArray
                         where data.EndsWith("A")//data.StartsWith("A") // data.Contains("A") || data.Contains("a")
                         select data;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            //Console.WriteLine("enter name to search");
            // string dataToSearch = Console.ReadLine();
            //var result = from data in nameArray
            //   where data = dataToSearch
            //   select data
            // var result = nameArray.Where(n => n == dataToSearch);
            var result = from data in nameArray
                         orderby data
                         select data;

                foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static void LinqToObjectDemoCustomerType()
        {
            List<Customer> custList = new List<Customer>() {
            new Customer{CustomerId = 101,Name="Alok",City="Pune"},
            new Customer{CustomerId = 102,Name="Danish",City="Delhi"},
            new Customer{CustomerId = 103,Name="Dev",City="Mumbai"},
            new Customer{CustomerId = 104,Name="Aliya",City="Mumbai"},
            new Customer{CustomerId = 105,Name="Megha",City="Delhi"}
            };
            var data = new { orderID = 110, OrderDate = "12/10/2025", TotalAmount = 14000 };//annonymous object
            var result = custList.Where(cust => cust.City == "Mumbai");
            var result1 = custList.Find(cust => cust.City == "Delhi");
            /*var result1 = custList.Find(cust => cust.City == "Delhi");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.CustomerId}\t{item.Name}\t{item.City}");
            }*/
            // find can only give one value n it can not ittreate 
            // in linq to sql we use where only while in linq to object we can use any
            foreach (var item in result)
            {
                Console.WriteLine($"{item.CustomerId}\t{item.Name}\t{item.City}");
            }
            
        }
        static void Main(string[] args)
        {
            // LinqToObjectDemo();
            LinqToObjectDemoCustomerType();
        }
    }
}
