using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog._2
{
    public class SurnamesArray
    {
        private string[] surnames;

        public SurnamesArray(string[] inputSurnames)
        {
            surnames = inputSurnames;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < surnames.Length)
                {
                    return surnames[index];
                }
                else
                {
                    return "Недійсний індекс";
                }
            }
            set
            {
                if (index >= 0 && index < surnames.Length)
                {
                    surnames[index] = value;
                }
            }
        }

        public string GetSurnamesStartingWith(char letter)
        {
            string result = string.Join("\n", surnames.Where(surname => surname.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase)));
            return result;
        }
    }
}
