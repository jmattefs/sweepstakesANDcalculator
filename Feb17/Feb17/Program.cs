using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemString ss = new SystemString("TheString");
            string one = ss.CreateString("one");
            string two = ss.CreateString("two");
            ss.Insert(one, 0);
            int three = ss.Length(one);
            ss.Remove(1, 3);



            char[] ThisArray = new char[] { };
            SystemArrayString sas = new SystemArrayString(ThisArray);
            string arrayOne = sas.CreateString("one");
            string arrayTwo = sas.CreateString("two");
            ss.Insert(one, 0);
            int arrayThree = ss.Length(one);
            ss.Remove(1, 2);



            LinkedList<string> TheLinkedList = new LinkedList<string>();
            SystemLinkedListString slls = new SystemLinkedListString(TheLinkedList);
            string LLone = slls.CreateString("one");
            string LLtwo = slls.CreateString("two");
            LinkedListNode<string> A = new LinkedListNode<string>(LLone);
            LinkedListNode<string> B = new LinkedListNode<string>(LLtwo);
            ss.Insert(one, 0);
            int LLthree = ss.Length(LLone);
            ss.Remove(0, 2);


            LinkedList<string> CustomLinkedList = new LinkedList<string>();
            CustomLinkedListString clls = new CustomLinkedListString(CustomLinkedList);
            string cllsOne = clls.CreateString("one");
            string cllsTwo = clls.CreateString("two");
            LinkedListNode<string> A1 = new LinkedListNode<string>(cllsOne);
            LinkedListNode<string> B2 = new LinkedListNode<string>(cllsTwo);
            ss.Insert(one, 0);
            int cllsThree = ss.Length(LLone);
            ss.Remove(0, 2);



            SortedList<ICustomString, int> sortedStringList = new SortedList<ICustomString, int>();
            
        }
    }
}
