using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal interface ITransformer
    {
        char[] Transform(char[] message, int key);
    }
}
