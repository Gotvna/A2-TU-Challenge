using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0)
                return true;
            foreach (char c in input)
            {
                if (c != ' ') return false;
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
                throw new ArgumentException("t'es moche");
            string result = "";
            int i;
            // Alternate
            for (i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                result += a[i].ToString() + b[i].ToString();
            }

            // add the remaining chars at the end of the longest string
            if (a.Length > b.Length) b = a;
            for (int j = i; j < b.Length; j++)
            {
                result += b[j].ToString();
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            foreach (char c in a)
            {
                switch (c)
                {
                    // Ascii
                    case 'A':
                        result += 'a';
                        break;
                    case 'B':
                        result += 'b';
                        break;
                    case 'C':
                        result += 'c';
                        break;
                    case 'D':
                        result += 'd';
                        break;
                    case 'E':
                        result += 'e';
                        break;
                    case 'F':
                        result += 'f';
                        break;
                    case 'G':
                        result += 'g';
                        break;
                    case 'H':
                        result += 'h';
                        break;
                    case 'I':
                        result += 'i';
                        break;
                    case 'J':
                        result += 'j';
                        break;
                    case 'K':
                        result += 'k';
                        break;
                    case 'L':
                        result += 'l';
                        break;
                    case 'M':
                        result += 'm';
                        break;
                    case 'N':
                        result += 'n';
                        break;
                    case 'O':
                        result += 'o';
                        break;
                    case 'P':
                        result += 'p';
                        break;
                    case 'Q':
                        result += 'q';
                        break;
                    case 'R':
                        result += 'r';
                        break;
                    case 'S':
                        result += 's';
                        break;
                    case 'T':
                        result += 't';
                        break;
                    case 'U':
                        result += 'u';
                        break;
                    case 'V':
                        result += 'v';
                        break;
                    case 'W':
                        result += 'w';
                        break;
                    case 'X':
                        result += 'x';
                        break;
                    case 'Y':
                        result += 'y';
                        break;
                    case 'Z':
                        result += 'z';
                        break;
                    // Extended Ascii
                    case 'À':
                        result += 'à';
                        break;
                    case 'Â':
                        result += 'â';
                        break;
                    case 'Ä':
                        result += 'ä';
                        break;
                    case 'Ç':
                        result += 'ç';
                        break;
                    case 'È':
                        result += 'è';
                        break;
                    case 'É':
                        result += 'é';
                        break;
                    case 'Ê':
                        result += 'ê';
                        break;
                    case 'Ë':
                        result += 'ë';
                        break;
                    case 'Î':
                        result += 'î';
                        break;
                    case 'Ï':
                        result += 'ï';
                        break;
                    case 'Ô':
                        result += 'ô';
                        break;
                    case 'Ö':
                        result += 'ö';
                        break;
                    case 'Ù':
                        result += 'ù';
                        break;
                    case 'Û':
                        result += 'û';
                        break;
                    case 'Ü':
                        result += 'ü';
                        break;
                    case 'Ÿ':
                        result += 'ÿ';
                        break;
                    default:
                        result += c;
                        break;
                }
            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string result = "";
            List<char> voyelles = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            
            foreach (char c in ToLowerCase(a))
            { 
                if (voyelles.Contains(c))
                {
                    voyelles.Remove(c);
                    result += c;
                }
            }
            return result;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }
        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i += 2)
                result += input[i];
            for (int i = 1; i < input.Length; i += 2)
                result += input[i];
            return result;
        }

        public static string UnBazardString(string input)
        {
            string a = input.Substring(0, input.Length / 2);
            string b = input.Substring(input.Length / 2);
            return MixString(a, b);
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";
            foreach (char c in input)
            {
                if ('a' <= c && c <= 'z')
                {
                    result += (char)((c - 'a' + offset) % 26 + 'a');
                }

                else if ('A' <= c && c <= 'Z')
                {
                    result += (char)((c - 'A' + offset) % 26 + 'A');
                }

                else result += c;
            }
            return result;
        }
    }
}
