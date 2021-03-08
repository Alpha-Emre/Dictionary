using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Id, Customer>
    {
        Id[] Keyarray;
        Customer[] Valuearray;
        public MyDictionary()
        {
            Keyarray = new Id[0];
            Valuearray = new Customer[0];
        }
        public void Add(Id ıd, Customer customer)
        {
            Id[] TempKeys = new Id[Keyarray.Length];
            Customer[] TempValue = new Customer[Valuearray.Length];

            TempKeys = Keyarray;
            TempValue = Valuearray;

            Keyarray = new Id[Keyarray.Length + 1];
            Valuearray = new Customer[Valuearray.Length + 1];

            for (int i = 0; i < TempKeys.Length; i++)
            {
                Keyarray[i] = TempKeys[i];
                Valuearray[i] = TempValue[i];

            }
            Keyarray[Keyarray.Length - 1] = ıd;
            Valuearray[Valuearray.Length - 1] = customer;
        }
        public void List()
        {
            for (int i = 0; i < Keyarray.Length; i++)
            {
                Console.WriteLine("ID:" + Keyarray[i] + " Customer: " + Valuearray[i]);

            }

        }
    }
}
