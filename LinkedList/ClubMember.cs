using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
  public  class ClubMember
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Member {Nr} {Fname} {Lname} Age: {Age}";
        }
        public ClubMember(int nr, string fname, string lname, int age)
        {
            this.Nr = nr;
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
        }
         public ClubMember() { }

    }
}
