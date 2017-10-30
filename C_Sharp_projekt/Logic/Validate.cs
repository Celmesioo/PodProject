using System;
using System.Collections.Generic;

namespace Logic
{
    public class Validate
    {

        public class InvalidInputException : Exception
        {
            public InvalidInputException(string message)
            {
                Message = message;
            }

            public string Message { get; }
        }

        internal bool Input_not_empty(params string[] inputs)
        {
            foreach (var item in inputs)
            {
                if (item.Equals(string.Empty))
                {
                    throw new InvalidInputException("En eller flera textrutor är tomma, kontollera och försök igen.");
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

        internal bool Input_does_not_exist_in_list(string input, List<String> list)
        {
            foreach (var item in list)
            {
                string itemAsUpper = item.ToUpper();
                if (itemAsUpper.Equals(input.ToUpper()))
                {
                    throw new InvalidInputException("En kategori med det namnet existerar reda, vänligen välj något annat.");
                }
            }
            return true;
        }

        internal bool If_not_default_category(string toDelete)
        {
            string default_category = "övrigt";
            if (default_category.ToUpper().Equals(toDelete.ToUpper()))
            {
                throw new InvalidInputException("Övrigt kategorin kan inte raderas eller ändras");
            }

            return true;
        }
    }
}
