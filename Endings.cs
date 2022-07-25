using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endings
{
    public class Endings
    {
        string root = "рубл";
        public string ConvertsEndings( int number )
        {
            string word = number.ToString().Remove(0, number.ToString().Length - 1);
            switch (word)
            {
                case "0":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    root += "ей";
                    break;
                case "1": root += "ь";
                    break;
                case "2":
                case "3":
                case "4":
                    root += "я";
                    break;
            }
            Console.WriteLine($"Общее количество: {number} {root}");
            return root;
        }
    }
}
