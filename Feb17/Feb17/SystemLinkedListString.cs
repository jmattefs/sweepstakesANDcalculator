using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
   public class SystemLinkedListString : ICustomString
    {
        LinkedList<string> TheLinkedList = new LinkedList<string>();
        public SystemLinkedListString(LinkedList<string> theLinkedList)
        {
            this.TheLinkedList = theLinkedList;
        }
        public string CreateString(string list)
        {
            
            list = TheLinkedList.ToString();
            return list;
        }

        public int Length(string x)
        {
            int TLLlength;
            x = TheLinkedList.ToString();
            TLLlength  = x.Count();
            return TLLlength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }

        public void Insert(string stringToInsert, int index)
        {
            
            if (index == 0)
            {              
                TheLinkedList.AddFirst(stringToInsert);
            } else if (index == TheLinkedList.Count)
            {
                TheLinkedList.AddLast(stringToInsert);
            }
            else
            {
                LinkedListNode<string> PreviousNode = new LinkedListNode<string>("");
                TheLinkedList.AddAfter(PreviousNode, stringToInsert);
            }
            

        }
    }

    
}
