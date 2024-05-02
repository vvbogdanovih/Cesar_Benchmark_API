using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_consol
{
    public class SimpleResult
    {
        public double ElapsedTime { get; set; }
        public int Size {  get; set; }
        public SimpleResult(int size, double time)
        {
            Size = size;
            ElapsedTime = time;
        }

    }
}
