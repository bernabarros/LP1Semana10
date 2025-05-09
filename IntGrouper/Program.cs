using System;
using System.Collections.Generic;
using System.IO;

namespace IntGrouper
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<string>path_list = new List<string>();
            HashSet<int>int_set = new HashSet<int>();

            string s_line;
            int int_line;

            if(args != null)
            {
                foreach(string path in args)
                {
                    path_list.Add(path);
                }  
            }
            foreach(string file_path in path_list)
            {
                using StreamReader sr = new StreamReader(file_path);
                while ((s_line = sr.ReadLine()) != null)
                {
                    int_line = int.Parse(s_line);
                    if(int_set.Contains(int_line) == false) int_set.Add(int_line);
                }
                foreach(int int_num in int_set)
                {
                    Console.WriteLine(int_num);
                }
            }
        }
    }
}
