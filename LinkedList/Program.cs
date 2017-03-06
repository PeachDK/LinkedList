using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            ClubMember clubmember1 = new ClubMember(1,"Peter", "Merrild",21);
            ClubMember clubmember2 = new ClubMember(2, "Pelle", "Hansen", 24);
            ClubMember clubmember3 = new ClubMember(3, "Elias", "Ehlers", 30);
            ClubMember clubmember4 = new ClubMember(4, "Johannses", "Jr.Diller", 20);    

            MyList mylist = new MyList();
            mylist.Insert(clubmember1);
            mylist.Insert(clubmember2);
            mylist.Insert(clubmember3);
            mylist.Insert(clubmember4);

            Console.WriteLine("First 4 Members(normal Insert)");
            Console.WriteLine(mylist.ToString());
         

            Console.WriteLine("Search for Index 2:");
            Console.WriteLine(mylist.Search(2).ToString());
            Console.WriteLine();

            Console.WriteLine("Delete (normal)");
            mylist.Delete();
            Console.WriteLine(mylist.ToString());

            mylist.Insert(clubmember4, 0);
            Console.WriteLine("Insert Memeber again index 0 (Johannes)");            
            Console.WriteLine(mylist.ToString());

            Console.WriteLine("Delete (index 1)");
            mylist.Delete(1);          
            Console.WriteLine(mylist.ToString());

            ClubMember clubmember5 = new ClubMember(5, "Julius", "Jensen", 25);
            ClubMember clubmember6 = new ClubMember(6, "Palle", "Jonson", 34);
            ClubMember clubmember7 = new ClubMember(7, "Maria", "Petersen", 39);
            ClubMember clubmember8 = new ClubMember(8, "Marius", "Holleness", 16);

            Console.WriteLine("Insert again: Member 6 on index 0 and Member 8 on 3. 5 and 7 normal add");
            mylist.Insert(clubmember5);
            mylist.Insert(clubmember6, 0);
            mylist.Insert(clubmember7);
            mylist.Insert(clubmember8, 3);

            Console.WriteLine(mylist.ToString());

            Console.ReadKey();
        }
    }
}
