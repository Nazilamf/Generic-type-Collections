using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_type__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("================Generic Collection================");


            List<string> list = new List<string>();

            list.Add("Leyla Quliyeva");
            list.Add("Gunay Bayramova");
            list.Add("Ferid Abbasov");
            list.Add("Nicat Babayev");
            list.Add("Gunel Aliyeva");


            list.Remove("Leyla Quliyeva");

            list.RemoveAt(3);

            list.Add("Samil Mammedov");

            List<string> list2 = new List<string>();
            list.Add("Gunay Bayramova");
            list.Add("Ceyhun Bayramov");


            list.AddRange(list2);

            Console.WriteLine(list.Contains("Samil Mammedov"));

            list.Reverse();
            list.Sort();

            Console.WriteLine(list.Capacity);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, int> animals = new Dictionary<string, int>();

            animals.Add("Cat", 1);
            animals.Add("Dog", 2);
            animals.Add("Panda", 3);
            animals.Add("Rabbit", 4);


            animals.Remove("Dog");

            Console.WriteLine(animals.Count);

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            SortedList<string, int> products = new SortedList<string, int>();

            products.Add("Snikers", 2);
            products.Add("Nestle", 3);
            products.Add("Oreo", 5);



            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


            Queue<string> names = new Queue<string>();

            names.Enqueue("Cavid");
            names.Enqueue("Dilare");
            names.Enqueue("Aysel");
            names.Enqueue("Orxan");

            names.Peek();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            names.Dequeue();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Stack<int> nums = new Stack<int>();
            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            nums.Push(4);
            nums.Push(5);
            nums.Push(6);

            nums.Peek();
            nums.Pop();
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }



            ArrayList cars = new ArrayList();

            cars.Add("Bmw");
            cars.Add("Kia");
            cars.Add('c');
            cars.Add(12);

            ArrayList cars1 = new ArrayList();
            cars1.Add("Range Rover");
            cars1.Add('b');

            cars1.AddRange(cars);

            cars1.Reverse();

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }



            foreach (var item in cars1)
            {
                Console.WriteLine(item);
            }


            Hashtable hashtable = new Hashtable();

            hashtable.Add(001, "Baku");
            hashtable.Add(002, "Gence");
            hashtable.Add(003, "Sheki");
            hashtable.Add(004, "Lankaran");

            
        }
    }
}
