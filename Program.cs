using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = " ";
            int spaceCount = 0;
            int count = 0;
            string input = "What is my name What is my name what is my name";
            string Q = "name";
            spaceCount = spaceCountF(input);
            for(int i = 0; i <= spaceCount+1; i++)
            {
                temp = getParse(input , i-1);
                if(temp == Q)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        static int spaceCountF(string input)
        {
            int spaceCount = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    spaceCount++;
                }

            }
            return spaceCount;
        }
        static string getParse(string input , int j)
        {
            string outFunc = "";
            int spaceCount = 0;
            for(int i = 0; i < input.Length; i++)
            {

                if(spaceCount == j)
                {
                    if(input[i] != ' ')
                        outFunc = outFunc + input[i];
                }
                if(input[i] == ' ')
                {
                    spaceCount++;
                }
            }
            return outFunc;
        }
    }
}
