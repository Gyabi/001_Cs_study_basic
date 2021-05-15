using System;
using System.Collections.Generic;
using System.IO;

namespace Cs_study_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            string a = null;
            string output_path = "./out.txt";
            
            while(a != "end"){
                Console.WriteLine("入力:");
                a = Console.ReadLine();
                lst.Add(a);
            }

            foreach(string x in lst){
                Console.WriteLine(x);
            }

            if(!File.Exists(output_path)){
                File.WriteAllLines(output_path, lst);
            }
            // ブランチ2
        }
    }
}
