using System.Text.RegularExpressions;

namespace homework4
{
    internal class Program
    {
        //task1
        static bool task1(string s)
        {
            string p = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            return Regex.IsMatch(s, p);
        }
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine(task1("192.192.192.192"));
            Console.WriteLine(task1("255.255.255.255"));
            Console.WriteLine(task1("999.1.1.1")); // false
        }
    }
}
