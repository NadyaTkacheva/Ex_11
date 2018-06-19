using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        public static void Revers(string []sent)
        {
            string[] word = null;
            //string [] sent;
            //sent = str.Split(',');
            int k = 0, d = 0, n = 0;
            int result = 0;
            // str = "";
            //string key = "";
            //for (int j = 0; j < sent.Length; j++)
            //{
            //    word[j] = sent[j].Substring(j, j + 1);

            //}
            for (int i=0; i<sent.Length; i+=3)
            {
                for (int j=0; j<i+3; j++)
                {
                    result = String.Compare(sent[i], sent[j]);
                    if ( result==0)
                    {
                        k++;
                    }
                    
                }
                if (k >= 1)
                {
                    Console.WriteLine(sent[i]);
                }
                else
                    Console.WriteLine(sent[i + 1]);
            }            
        }
        //Console.WriteLine(str);
        static string[] InputStr()
        {
            string a = "s";
            char ch = ',';
            bool ok;
            do
            {
                try
                {
                    a = Convert.ToString(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите строку");
                    ok = false;
                }
            } while (!ok);
            string[] s;
            string[] sent = new string[a.Length];
            int index = a.IndexOf(ch);
            if (index < 0)
            {         
                for (int j = 0; j < a.Length; j++)
                {
                     sent[j] = a.Substring(j, 1);
                }
                
            }
            else
                sent = a.Split(',');

                return sent;
        }

        static void Main(string[] args)
        {

            Revers(InputStr());
            Console.ReadKey();
        }
    }
}
