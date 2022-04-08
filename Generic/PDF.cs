using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class PDF : IPrintable
    {
        public int PageCount { get; set; }

        public string FileNAme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PDF(int pagecount)
        {
            PageCount = pagecount;
        }
        public void Print()
        {
            Console.WriteLine($"SAy:{PageCount}");
        }
    }
}

