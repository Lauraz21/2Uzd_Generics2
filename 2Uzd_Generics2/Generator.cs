using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Uzd_Generics2
{
    public class Generator<T>
    {
        public void Show(T value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
