using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
    class Student
    {
        static string collegeName;
        int rollNo, cls, sem, total = 0,avg=0;
        string name, branch;
        public static void cname(string clName)
        {
            collegeName = clName;
            Console.WriteLine(collegeName);
        }
        public Student() { }
        public Student(int rollNo, string name, int cls, int sem, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.cls = cls;
            this.sem = sem;
            this.branch = branch;



        }
        public void mark()
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter marks in each subject : ");
            for (int sub = 0; sub <5; sub++)
            {
                marks[sub] = int.Parse(Console.ReadLine());
            }
    
            
            for (int subjs = 0; subjs < 5; subjs++)
            {
                if (marks[subjs] < 35)
                    Console.WriteLine("Failed");
                break;
            }


            for (int subj = 0; subj < 5; subj++)
            {
                total = total + marks[subj];
            }
            avg = (total / 5);


            if (avg < 50)
            {
                Console.WriteLine("Failed");
            }
            else
                Console.WriteLine("Passed");
         }
        public void Display()
        {
            Console.WriteLine("College Name : " + collegeName   + "\nRollNo : " + this.rollNo + "\nName :" + this.name + "\nclass  : " + this.cls + "\nSem : " + this.sem + "\nBranch : " + this.branch + "\ntotal : " + this.total + "\naverage : " + this.avg);
        }



        class Program
        {

            static void Main(string[] args)
            {
                Student s = new Student();
                Student.cname("KHIT");
                Console.WriteLine("Enter RollNo : ");
                int rollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Class : ");
                int cls = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Sem : ");
                int sem = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Branch Name : ");
                string branch = Console.ReadLine();

                Student st = new Student(rollNo, name, cls, sem, branch);
                st.mark();
                st.Display();



                Console.ReadKey();
            }
        }

        }
    }

