using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegatedemo
{//multicast delegate, return type is void
    public delegate void GreetMsg(string msg);
    //unicast delegate, there is a return type
    public delegate int Calculation(int num1, int num2);
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat " + userName);   
        }
    }
    class Tamil
    {// instance method
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("varakam " + userName);
        }
    }
    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram " + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namasker " + userName);
        }
    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        { Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);
            GreetInTamil("Alok");
        }
    }
}
