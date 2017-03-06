using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
      

    }
}
