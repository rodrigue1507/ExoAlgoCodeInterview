using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace ArrayAndString
{
    public class ArrayAndStringExercises
    {
        public bool IsUnique(string s)
        {
            var checker = new HashSet<char>();
            foreach (char c in s)
            {
                if (!checker.Add(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPermutation(string s1, string s2)
        {
            var checker = new HashSet<char>();
            if (s1.Length != s2.Length) return false;
            
            foreach (char c in s1)
            {
                if(checker.Add(c)) 
                {
                    if (CaractereFrequency(c, s1) != CaractereFrequency(c, s2)) return false;
                }    
            }
            return true;
        }

        private int CaractereFrequency(char c, string s)
        {
            var counter = 0;
            foreach (var caratere in s)
            {
                if (caratere == c && caratere != ' ') 
                {
                    counter += 1;
                }
            }
            return counter;
        }

        public string Urlify(string s, int stringLenght)
        {
            var stb = new StringBuilder();
            for (int i = 0; i < stringLenght; i++)
            {
                if (s[i] == ' ')
                {
                    stb.Append("%20");
                }
                else
                {
                    stb.Append(s[i]);
                };
            }
            return stb.ToString();
        }

        public bool PalindromePermutation(string s)
        {
            var str = s.ToUpper();
            foreach (var c in str)
            {
                var checkFrequency = CaractereFrequency(c, str);
                if(checkFrequency != 1)
                {
                    if ((checkFrequency % 2 != 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool OneWay(string s1, string s2)
        {
            var result = true;
            if (Math.Abs(s1.Length - s2.Length) >= 2) return false;
            if (Math.Abs(s1.Length - s2.Length) == 1 || (s1.Length - s2.Length) == 0 ) 
            {
                result = IsItGood(s1, s2, 2);
            }
            return result;
        }

        private bool IsItGood(string s1,string s2,int fixedLimit)
        {
            var checkIt = new HashSet<char>();
            var countModif = 0;
            for (int i = 0; i < s1.Length; i++) checkIt.Add(s1[i]);
            for (int i = 0; i < s2.Length; i++)
            {
                if (checkIt.Add(s2[i])) countModif++;
                if (countModif >= fixedLimit) return false;
            }
            return true;
        }
        public string CompressString(string s1)
        {
            var result = new StringBuilder();
            int countCaractere = 0;
            int countCaractereEnd = 0;
            var testDic = new HashSet<char>();
            for ( int i = 0; i < s1.Length; i++)
            {
                if (testDic.Add(s1[i]))
                {
                    result.Append(s1[i]);
                    countCaractere++;
                }
                else
                {
                    countCaractere++;
                };
                if (i != (s1.Length - 1)) 
                {
                    if (!testDic.TryGetValue(s1[i + 1], out char actualValue))
                    {
                        result.Append(countCaractere.ToString());
                        countCaractere = 0;
                    }
                };

                if(s1[i] == s1[s1.Length-1]) 
                {
                    countCaractereEnd++;
                }
            }
            result.Append(countCaractereEnd.ToString());
            return result.ToString();
        }

        public byte[,] RotateMatrix(byte[,] originMatrix, byte[,] rotateMatrix)
        {


        }
    }
}
