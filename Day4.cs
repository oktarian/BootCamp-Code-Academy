using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class MyCollections
    {
        public static void InitList()
        {
            var alfafbet = new List<string> { "A", "B", "C", "D", "E" };
            alfafbet.Add("F");
            alfafbet.AddRange(new[] { "G", "H", "I" });
            alfafbet.Insert(0, "J");
            alfafbet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfafbet)
            {
                Console.Write($"{item}");
            }

            //remove element from list<T
            alfafbet.Remove("X");
            alfafbet.RemoveRange(4, 6);
            alfafbet.RemoveAll(V => V == "X");

            //Clear
            alfafbet.Clear();

            //Declare List<int>
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Add(9);
            numbers.Remove(3);
            numbers.RemoveAll(v => v >= 4);

            foreach (var item in numbers)
            {
                Console.Write($"{item}");
            }

            //Find element atau searching
            var a = numbers.Find(v => v < 6);//ini diambil nilai terkecil
            var b = numbers.FindLast(v => v < 11);//ini diambil nilai terbesarnya
            var c = numbers.FindAll(v => v <= 10);


            //find index element
            var d = numbers.FindIndex(v => v <= 6);
            var e = numbers.FindLastIndex(v => v <= 6);
            var f = numbers.IndexOf(6);
            var g = numbers.BinarySearch(6);

            Console.WriteLine();



        }
        //STACK (last in first out)
        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3, 4 });
            numbers.Push(5);
            numbers.Push(6);

            //remove stack dengan POP
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

        }

        //Dictionary
        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "palembang");
            pl.Add(2, "UIN");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "green day" },
                {2, "blink 182" },
                {3, "MCR" }

            };

            //add new element
            pl2.Add(4, "radio head");
            pl2.TryAdd(4, "paramore");
            pl2[4] = "paramore";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
            Console.WriteLine();
        }

        //HASHSET
        public static void InitHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 4, 5, 6 };
            numbers.Add(11);
            numbers.Add(10);
            numbers.Add(5);

            var hs1 = new HashSet<int>() { 1, 2, 4, 5, 6 };
            var hs2 = new HashSet<int>() { 1, 2, 4 };
            var result1 = new HashSet<int>(hs1);

            result1.IntersectWith(hs2);//inner join

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2);//union 

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2);//union 

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2);//union 


            //convert HASHSET to list
            var myNumber = result4.ToList();

            Console.WriteLine();

        }

        public static void InitQueue()
        {
            var queue = new Queue<string>();

            queue.Enqueue("green day");
            queue.Enqueue("paramore");
            queue.Enqueue("radio head");

            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item}");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"served : {served}");
        }

        //return List<>
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();


            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }

        //soal 1
        
        public static List<T> soal1<T>(ref List<T> A, ref List<T> B)
        {

            var myList = A;
            var myList2 = B;

            var result1 = new HashSet<T>(myList2);
            result1.IntersectWith(myList);//irisan 
            Console.WriteLine("Tampilkan element yang sama (A irisan B) :");
            foreach (var item in result1)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine();

            var result2 = new HashSet<T>(myList2);
            result2.UnionWith(myList);//Union
            Console.WriteLine("Merge dan tampilkan element (A union B) :");

            foreach (var item in result2)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();

            var result3 = new HashSet<T>(myList);
            result3.ExceptWith(myList2);//Tampilkan element di A yang tidak sama dengan B
            Console.WriteLine("Tampilkan element di A yang tidak sama dengan B :");

            foreach (var item in result3)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();

            var result4 = new HashSet<T>(myList2);
            result4.SymmetricExceptWith(myList);//Tampilkan element yang tidak sama di A & B
            Console.WriteLine("Tampilkan element yang tidak sama di A & B :");
            foreach (var item in result4)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            return myList;
        }
        //soal2         
       
        public static List<T> Reverse<T>(ref List<T> list)
        {
            var myList = new List<T>();


            foreach (var item in list)
            {
                myList.Add(item);
            }
            myList.Reverse();
            return myList;
        }

        //soal3      

        public static List<T> Remove<T>(ref List<T> list)
        {
            var myList = new List<T>();
           

            foreach (var item in list)
            {
                myList.Add(item);
            }
            
            var myList2 = myList.Distinct().ToList();


            return myList2;
        }

        //soal4

        //soal5
        public static void soal5()
        {
            var array1 = new List<string> { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
            var array2 = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };

            var same = new List<string>();
            var diff = new List<string>();

            for (int i = 0; i < array1.Count; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    if (!same.Contains(array1[i]))
                    {
                        same.Add(array1[i]);
                    }
                }
                else
                {
                    diff.Add(array1[i]);
                }
            }
            for (int j = 0; j < array2.Count; j++)
            {
                if (!array1.Contains(array2[j]))
                {
                    if (!diff.Contains(array2[j]))
                    {
                        diff.Add(array2[j]);
                    }
                }

            }
            Console.Write("Same = ");
            Display(same);
            Console.Write("\nDifferent = ");
            Display(diff);
        }

        public static void Display(List<string> x)
        {
            foreach (var i in x)
            {
                Console.Write(i + " ");
            }
        }

    //soal6

    }
}
