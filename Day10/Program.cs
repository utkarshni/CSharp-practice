// See https://aka.ms/new-console-template for more information
using eventdelegatedemo;
using System;
    namespace eventdelegatedemo
{

    public delegate bool CreateRecord(Product P); // we can't use T in place of product P bcs this delegate can't be generic //also if product is internal it will show error bcz delegate is public n can't use internal with public
    public delegate void Caller(string str);
    class Program
    {
        public static void ShowMe(string str)
        {

            Console.WriteLine("Show Me Called");
        }
        public void GenerateBill(string str)
        {
            Console.WriteLine("Generate Bill Called");
        }
        static void Main(string[] args)
        {
            /*Program p1 = new Program();
            Caller CallMe = new Caller(Program.ShowMe);
            CallMe += new Caller(p1.GenerateBill);//if we do this CallMe -= new Caller(p1.GenerateBill); than only show me called will show but u first have to do += if u want to add both , also u can run with = only it will print generated bill called
            CallMe("LPU");*/
           

            /*ProductRepo pRepo = new ProductRepo();
            CreateRecord AddProduct = new CreateRecord(pRepo.Add);
            AddProduct(new Product());// here add is acting as a pointer*/
        }
    }

}
//covariance depends on return type of method(base class can hold child class) , contravarience depends on argument 
