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

        internal bool Interval_is_valid(string interval)
        {
            double result;
            bool isParseble =  double.TryParse(interval,  out result);
            return isParseble;
        }

        internal bool Category_does_not_exist(string input, List<String> list)
        {
            foreach (var item in list)
            {
                string itemAsUpper = item.ToUpper();
                if (itemAsUpper.Equals(input.ToUpper()))
                {
                    throw new ApplicationException("Den categorin finns redan");
                }
            }
            return true;
        }
    }
}
