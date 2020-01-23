using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var i = 5;
            i = 20;

            dynamic x;
            x = 56;

            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add("Pranavi");
            al.Add(3.67);
            al.Add('g');

            foreach (var val in al)
                Console.WriteLine(val);

            Queue ql = new Queue();
            ql.Enqueue(12);
            ql.Enqueue("Giridhar");
            ql.Enqueue('p');
            Console.WriteLine(ql.Dequeue());

            Console.WriteLine("\n");


            foreach (var val in ql)
                Console.WriteLine(val);

            Stack s = new Stack();
            s.Push(23);
            s.Push("hello");
            s.Push(56.678);
            Console.WriteLine("\n"+s.Pop());
            Console.WriteLine("\n"+s.Peek());
            foreach (var vals in s)
                Console.WriteLine(""+vals);


            Hashtable ht = new Hashtable();
            ht.Add( "Pranavi",1);
            ht.Add( 324554,2);
            ht.Add('g',3);
            Cforeonsole.WriteLine("HashTable  \n");
            foreach(var values in ht.Keys)
            {

                Console.WriteLine(""+values);
                //Console.WriteLine("\n" + ht[values]);

            }

            
            Console.WriteLine("List: ");
            List<int> list = new List<int>();
            list.Add(100);
            list.Add('g');
            foreach (int val in list)
                Console.WriteLine("  "+val);


            Console.WriteLine("\n\nQueue: ");
            Queue<string> ql = new Queue<string>();
            ql.Enqueue("jgkj");
            ql.Enqueue("Giridhar");
            ql.Enqueue("pighkl");
            Console.WriteLine("  "+ql.Dequeue());
            foreach (var val in ql)
                Console.WriteLine("  "+val);


            Console.WriteLine("\n\nStack: ");
            Stack<float> st = new Stack<float>();
            st.Push(23);
            st.Push(546.7f);
            st.Push(56.678f);
            Console.WriteLine("\nPop : " + st.Pop());
            Console.WriteLine("Peek : " + st.Peek());
            foreach (var vals in st)
                Console.WriteLine("" + vals);

            Console.WriteLine("\n\nHashSet: ");
            HashSet<int> hs = new HashSet<int>();
            hs.Add(100);
            hs.Add(7);
            hs.Add(7);
            hs.Add(23);
            hs.Add(9);
            foreach (var vals in hs)
                Console.WriteLine("" + vals);


            Console.WriteLine("\n\nDictionary : ");
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1,"Pranavi");
            dt.Add(2,"lkfsdg");
            dt.Add(3,"sdfgdfdrth");

            foreach(KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }

    */


            Dictionary<string,int> dt = new Dictionary<string,int>();
            Console.WriteLine("Enter no.of Employees");
            int emp = int.Parse(Console.ReadLine());
            
            for(int i=0;i<emp;i++)
            {
                Console.WriteLine("Enter employee name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter employee salary :");
                int sal = int.Parse(Console.ReadLine());
                dt.Add(name,sal);
            }
            int high=0;
            string hname="";
            foreach (KeyValuePair<string, int> k in dt)
            {
                if(k.Value>high)
                {
                    high = k.Value;
                    hname = k.Key;
                }
               
                //Console.WriteLine(k.Value);

                
            }
            Console.WriteLine("The Highest Paid Employee is : " + hname);
            Console.ReadKey();
        }

       
        }
    }

