using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Anagrams
{
    internal class AnagramService
    {
        internal string[] GetAnagramsFrom(string input)
        {
            return GetAnagrams(string.Empty, input, string.Empty).ToArray();
        }

        internal List<string> GetAnagrams(string inputAcumulado, string inputRestante, string indent)
        {
            Debug.Write(indent);
            if (inputRestante.Length == 0)
            {
                Debug.Write("└─");
                indent += " ";
            }
            else
            {
                Debug.Write("├─");
                indent += "| ";
            }

            Debug.WriteLine(inputAcumulado);

            List<string> results = new List<string>();

            if (String.IsNullOrEmpty(inputRestante))
            {
                return new List<string>() { inputAcumulado };
            }
            else
            {
                for (int i = 0; i < inputRestante.Length; i++)
                {
                    var currentChar = inputRestante[i];

                    results.AddRange(GetAnagrams(inputAcumulado + currentChar.ToString(), inputRestante.Remove(i, 1), indent));
                }
            }

            return results;
        }
    }
}

