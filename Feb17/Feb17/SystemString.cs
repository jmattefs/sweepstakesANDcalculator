using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    public class SystemString : ICustomString
    {
        string TheString;
        public SystemString(string theString)
        {
            this.TheString = theString;
        }
        public string CreateString(string th)
        {
            return th.ToString();
        }
        public void Insert(string stringToInsert, int startIndex)
        {
            stringToInsert.Insert(startIndex,stringToInsert);

        }

        public int Length(string x)
        {
            int stringLength = x.Length;
            return stringLength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            TheString.Remove(startIndex, numCharsToRemove);
        }
    }
}
