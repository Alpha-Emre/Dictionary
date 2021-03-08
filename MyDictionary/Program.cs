using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Id_customer = new MyDictionary<int, string>();
            Id_customer.Add(1, "Emre");
            Id_customer.Add(2, "Yunus");
            Id_customer.Add(3, "Çağrı");
            Id_customer.Add(4, "Yeliz");
            Id_customer.List();
        }
    }
}
