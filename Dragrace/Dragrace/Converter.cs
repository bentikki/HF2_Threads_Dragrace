using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragrace
{
    static class Converter
    {
        public static int KphToMph(double kmph)
        {
            return (int)(0.277778 * kmph);
        }
    }
}
