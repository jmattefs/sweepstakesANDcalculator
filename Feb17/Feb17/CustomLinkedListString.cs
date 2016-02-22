using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    public class CustomLinkedListString : ICustomString
    {
        LinkedList<string> CustomLinkedList = new LinkedList<string>();
        LinkedListNode<string> Node1 = new LinkedListNode<string>("");
        LinkedListNode<string> Node2 = new LinkedListNode<string>("");
        LinkedListNode<string> Node3 = new LinkedListNode<string>("");
        
        public CustomLinkedListString(LinkedList<string> customLinkedList)
        {
            this.CustomLinkedList = customLinkedList;
        }
        public string CreateString(string x)
        {
            string CLL=CustomLinkedList.ToString();
            return CLL;
        }
        public void Insert(string stringToInsert, int index)
        {
            if (index == 0)
            {
                CustomLinkedList.AddFirst(stringToInsert);
            }
            else if (index == CustomLinkedList.Count)
            {
                CustomLinkedList.AddLast(stringToInsert);
            }
            else
            {
                LinkedListNode<string> PreviousNode = new LinkedListNode<string>("");
                CustomLinkedList.AddAfter(PreviousNode, stringToInsert);
            }

        }

        public int Length(string x)
        {
            x = CustomLinkedList.ToString();
            int CLLlength = x.Count();
            return CLLlength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
