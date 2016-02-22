using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    public class SystemArrayString : ICustomString
    {
        char[] TheArray = new char[] { };
        public SystemArrayString(char[]theArray)
        {
            this.TheArray = theArray;
        }
        public  string CreateString(string x)
        {
            x = TheArray.ToString();
            return x;
        }
        public void Insert(string stringToInsert, int index)
        {
            TheArray.SetValue(stringToInsert, index);
        }

        public int Length(string x)
        {
            int arrayLength;
            arrayLength = x.Length;
            return arrayLength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            
        }
    }
}
