using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ') return false;

                }
            }

            return true;
        }

        public static string MixString(string a, string b)
        {
            string result = "";
            int lenghtMix;
            if (a == null || b == null || a == string.Empty || b == string.Empty)
            {
                throw new ArgumentException();
            }
            if (a.Length < b.Length)
            {
                lenghtMix = a.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    result += a[i];
                    result += b[i];
                }
                for (int i = lenghtMix; i < b.Length; i++)
                {
                    result += b[i];
                }
                return result;
            }
            if (a.Length > b.Length)
            {
                lenghtMix = b.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    result += a[i];
                    result += b[i];
                }
                for (int i = lenghtMix; i < a.Length; i++)
                {
                    result += a[i];
                }
                return result;
            }
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
                result += b[i];
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

        public static string ToCesarCode(string input, int offset)
        {
            string end = "";
            for(int c=0;c<input.Length;c++)
            {
                int tpm = 0;
                if ((int)input[c] >=65 && (int)input[c] <= 90 )
                {
                    if (input[c] + offset > 90) tpm = (int)input[c] + offset - 25;
                    else tpm = (int)input[c] + offset;
                    
                    end += (char)tpm;
                }
                if ((int)input[c] >= 97 && (int)input[c] <= 122)
                {
                    if (input[c]+offset >122) tpm = (int)input[c] + offset -26;
                    else tpm = (int)input[c]+ offset;
                    end += (char)tpm;
                }
                else
                {
                    end += input[c];
                }
                
            }
            return end;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            foreach (char c in a)
            {
                if (((int)c < 65 || (int)c > 90) && ((int)c < 182 || (int)c > 214))
                {
                    result += c;
                    continue;
                }
                int x = (int)c;
                x += 32;
                result += (char)x;
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                result += input[i];
                result += input[i + input.Length / 2];
            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string voyelles = "";

            for (int i = 0; i < a.Length; i++)
            {
                bool test = false;
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U' || a[i] == 'Y')
                {
                    if(voyelles.Length > 0)
                    {
                        foreach(char element in voyelles)
                        {
                            if (element == a[i])
                            {
                                test= true;
                            }
                        }
                    }
                    if(test==false) voyelles += a[i];
                };

            }
            return ToLowerCase(voyelles);
        }
    }
}
