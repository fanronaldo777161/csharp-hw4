using System.Text.RegularExpressions;

namespace homework4
{
    internal class Program
    {
        //task1
        public static bool task1(string s)
        {
            string p = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            return Regex.IsMatch(s, p);
        }
        //находит в строке все автомобильные номера и возвращает массив из них
        public static string[] iscarnum(string s)
        {
            string p = @"\b[АВЕКМНОРСТУХ]\d{3}[АВЕКМНОРСТУХ]{2}\d{2,3}\b";
            var ms = Regex.Matches(s, p);
            string[] r = new string[ms.Count];
            for (int i = 0; i < ms.Count; i++)
                r[i] = ms[i].Value;
            return r;
        }
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine(task1("192.192.192.192"));
            Console.WriteLine(task1("255.255.255.255"));
            Console.WriteLine(task1("999.1.1.1")); // false
            //task2
            string s = "Номера машин: А123ВЕ777, Х999ХХ99, не номер: Б111ББ11, еще один: М161НН161";
            var s1 = iscarnum(s);
            foreach(var i in s1)
                Console.Write(i + " ");
        }
    }
}
