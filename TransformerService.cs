using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class TransformerService
    {
        private readonly ITransformer transformer;

        public TransformerService(ITransformer transformer)
        {
            this.transformer = transformer;
        }

        public char[] Transform(char[] message, int key)
        {
            return transformer.Transform(message, key);
        }
    }
}
