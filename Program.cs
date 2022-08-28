using System.Collections;
using System.Collections.Generic;

namespace HashDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //we can not use var 
            //it doesn't take duplicate value
            //need key and value pair

            string paragraph = "Paranoids are no paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split();
            MyMapNode<int, string> hashMap = new MyMapNode<int, string>(para.Length);
            int count = 0;
            foreach (string word in para)
            {
                hashMap.Add(count, word);
                count++;
            }
            Frequency.FindFrequency(para);

            Console.WriteLine("==================");
            Console.WriteLine("Before Remove:");
            hashMap.Display();
            hashMap.Remove(5);
            Console.WriteLine("==================");
            Console.WriteLine("After remove: ");
            hashMap.Display();



        }
    }
}