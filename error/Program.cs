using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace error
{
    class MyExeption : Exception
    {
        public override string Message { get; }
        
        public MyExeption(string message)
        {
            Message = message;
        }
    }
    class Program
    {
        public void Calc(int x, int y)
        {
            int result=0;     
            try
            {
                result = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int t = 0;
            try
            {
                int[] array = new int[2];
                array[2] = 15;
                int x = 15 / t;

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finnaly");
            }

            //Calc(10, 0);

            try
            {
                throw new MyExeption("My Exeption");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Enter the string");
            string text = Console.ReadLine();

            //using (FileStream filestream = new FileStream(@"C:\Users\student\Desktop\myfile.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] array = Encoding.Default.GetBytes(text);
            //    filestream.Write(array, 0, array.Length);
            //    Console.WriteLine("Done");
            //}

            //using (FileStream filestr = File.OpenRead (@"C:\Users\student\Desktop\myfile.txt"))
            //{
            //    byte[] arr = new byte[filestr.Length];
            //    filestr.Read(arr, 0, arr.Length);
            //    string text2 = Encoding.Default.GetString(arr);
            //    Console.WriteLine(text2);
                    
            //}

            using (StreamWriter sw = new StreamWriter(@"C:\Users\student\Desktop\myfile1.txt", true, Encoding.Default))
            {
                sw.WriteLine(text);
            }
            List<string> list = new List<string>();
           

            using (StreamReader sr = new StreamReader(@"C:\Users\student\Desktop\myfile1.txt", Encoding.Default))
            {
                string yo;
                do
                {
                    yo = sr.ReadLine();
                    list.Add(yo);
                }
                while (yo != null);

            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
