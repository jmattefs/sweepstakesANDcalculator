using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    public interface ICustomString
    {
        string CreateString(string x);
        void Insert(string stringToInsert, int index);
        void Remove(int startIndex, int numCharsToRemove);
        int Length(string x);


    }
}
