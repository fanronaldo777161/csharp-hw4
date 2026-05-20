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
        //Преобразовать текст, обрамленный в звездочки, в текст обрамленный тегом <em></em>
        public static string starstoem(string s)
        {
            string p = @"(?<!\*)\*(?!\*)(.*?)(?<!\*)\*(?!\*)";
            return Regex.Replace(s, p, "<em>$1</em>");
        }
        //возвращает сумму продаж указанной валюты
        public static double sumofvalue(string s, string t)
        {
            string p = $@"(?<=\b{s}=)\d+(\.\d+)?";
            var ms = Regex.Matches(t, p);
            double sum = 0;
            foreach (Match m in ms) sum += double.Parse(m.Value, System.Globalization.CultureInfo.InvariantCulture);
            return sum;
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
            //task3
            Console.WriteLine(" ");
            string s3 = "Это *italic text*, а это **bold text (not italic)** ";
            Console.WriteLine(starstoem(s3));

            //task5
            string s5 = "USD=100 RUB=200.75 USD=70 BYN=800.40 EUR=800 JPY=1000 RUB=20";
            Console.WriteLine($"USD sum: {sumofvalue("USD", s5)}");
            Console.WriteLine($"RUB sum: {sumofvalue("RUB", s5)}");

            //task6
        }
    }
}
