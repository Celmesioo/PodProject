using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Validate
    {
        internal bool Input_not_empty(string input)
        {
            if (input.Equals(string.Empty))
            {
                throw new Exception();
            }
            return true;
        }

        internal bool Input_not_empty(params string[] inputs)
        {
            foreach (var item in inputs)
            {
                if (item.Equals(string.Empty))
                {
                    throw new Exception();
                }
            }
            return true;
        }
    }
}
