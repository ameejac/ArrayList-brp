using System;
using System.Collections;
using System.Linq;

namespace ArraylistCodePractice
{
    class ArrylistProgram
    {
	    //to store the elements in array
        public void AddElements()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            foreach (int elements in al)
            {
                Console.WriteLine(elements);
            }
	    //remove operation
            al.Remove(10);
            Console.WriteLine("after removing:" + al.Count);
            foreach (int elements in al)
            {
                Console.WriteLine(elements);
            }

            al.RemoveAt(1);
            Console.WriteLine("after removing:" + al.Count);
            al.RemoveRange(0, 2);
            Console.WriteLine("after removing:" + al.Count);
            foreach (int elements in al)
            {
                Console.WriteLine(elements);
            }
            al.Clear();
            Console.WriteLine("removing all elements:" + al.Count);
        }
	//sort operation
        public void sortmethod()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(30);
            list.Add(20);
            list.Add(50);
            list.Add(60);
            list.Add(40);

            list.Sort();
            Console.WriteLine("list size:" + list.Count);
            foreach (int items in list)
            {
                Console.WriteLine(items);
            }
        }
	//to store the elements in arralist
        public void AddString()
        {
            ArrayList al = new ArrayList();
            al.Add("ameeja");
            al.Add("reshu");
            al.Add("rehan");
            al.Add("alekya");
            al.Add("raju");
            foreach (String str in al)
            {
                Console.WriteLine("add the elements in arraylist:" + str);
            }

	    //remove method
            al.Remove("ameeja");
            Console.WriteLine("after removing:" + al.Count);
            foreach (string str in al)
            {
                Console.WriteLine(str);
            }
            al.RemoveAt(0);
            Console.WriteLine("after removing:" + al.Count);
            foreach (string str in al)
            {
                Console.WriteLine(str);
            }
            al.RemoveRange(0, 1);
            Console.WriteLine("after removing:" + al.Count);
            foreach (string str in al)
            {
                Console.WriteLine(str);
            }
            al.Clear();
            Console.WriteLine("remove all elements in arraylist:" + al.Count);
        }

	//sorting the elements in list
        public void Sortnames()
        {
            ArrayList list = new ArrayList();
            list.Add("Vinay");
            list.Add("Jaanu");
            list.Add("Raani");
            list.Add("Mahi");
            list.Add("Tanya");
            list.Add("sanah");
            list.Sort();
            Console.WriteLine("list size:" + list.Count);
            foreach (string elements in list)
            {
                Console.WriteLine("sort the elements in list:" + elements);
            }
        }
    }
}


