using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class PrintFileGen<T>where T : IPrintable
    {
        public string FileNAme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal static void Print()
        {
            throw new NotImplementedException();
        }

        public void Print(T type)
        {
            type.Print();
        }
    }
}
