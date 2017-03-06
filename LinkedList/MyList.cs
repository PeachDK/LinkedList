using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    enum Sort
    {
        ByMemberID,
        ByFirstName,
        ByAge
    }
    class MyList
    {
        private Node Head { get; set; }

        public void Insert(object data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = Head.Next;
            Head.Next = node;
        }
        public void Insert(object data, int index)
        {
            Node node = new Node();
            Node temp = Head.Next;
            Node temp2 = temp;
            node.Data = data;

            if (index == 0)
            {
                Insert(data);
            }
            if (index > 0)
            {
                temp = (Node)Search(index - 1);
                temp2 = (Node)Search(index);
                if (temp.Next == null)
                {
                    Insert(data);
                }
                else
                {
                    node.Next = temp2;
                    temp.Next = node;
                }
            }
        }

        public void Delete()
        {
            Node temp = Head.Next;
            Head.Next = Head.Next.Next;
            temp = null;
        }
         public void Delete(int index)
        {
            if (index == 0)
            {
                Delete();
            }
            else {
                Node temp = (Node)Search(index - 1);
                Node temp2 = temp.Next;
                temp.Next = temp.Next.Next;
                temp2 = null;
            }
        }

        public MyList()
        {
            this.Head = new LinkedList.Node();
            Head.Next = null;
            Head.Data = null;
        }

        public override string ToString()
        {
            string data = "";

            Node temp = new Node();
            temp = Head;

            while (temp.Next != null)
            {
                data = data + temp.Next.Data + "\n";
                temp = temp.Next;
            }

            return data;
        }

        public object Search(int index)
        {
            Node temp = new Node();
            temp = Head.Next;

            for (int i = 0; i < index; i++)
            {
                if (temp.Next == null)
                {
                    return temp;
                }

                temp = temp.Next;
            }

            return temp;

        }

        public void Sort(Sort input)
        {
            switch (input)
            {
                case LinkedList.Sort.ByMemberID:
                    Node temp = Head.Next;
                    bool swapped = true;
                    while (swapped)
                    {

                    }

                    break;
                case LinkedList.Sort.ByFirstName:
                    break;
                case LinkedList.Sort.ByAge:
                    break;
                default:
                    break;
            }

        }

        private void Swap(Node n1, Node n2)
        {
            Node temp = new Node();
            temp = n2;
            n2 = n1;
            n1 = temp;
        }

        private void SortbyID(Node n1 , Node n2)
        {
            ClubMember c1 = (ClubMember)n1.Data;
            ClubMember c2 = (ClubMember)n2.Data;
                        
            if (c1.Nr < c2.Nr)
            {
                Swap(n1, n2);
            }         

        }

    }
}
