using System.Diagnostics;
using System.Text;

internal class Program
{
    delegate void MethodDo(UInt64 n);
    static void DoString(UInt64 n)
    {
        string s = "";
        for (UInt64 i = 0; i < n; i++)
        {
            s += "a";
        }
    }

    static void DoCharArray(UInt64 n)
    {
        char[] old_string = new char[n];
        for (UInt64 i = 0; i < n; i++)
        {
            old_string[i] = 'a';
        }
    }

    static double GetTimeDo(MethodDo function, UInt64 n)
    {
        Stopwatch timer = new Stopwatch();
        timer.Restart();
        // вызвать функцию
        function(n);
        timer.Stop();
        return timer.ElapsedMilliseconds;
    }
    private static void Main(string[] args)
    {
        UInt64 N = 200_000;

        Console.WriteLine("string " + GetTimeDo(DoString, N));

        Console.WriteLine("char[] " + GetTimeDo(DoCharArray, N));


        //timer.Restart();
        //List<char> list_string = new List<char>();
        //for (UInt64 i = 0; i < N; i++)
        //{
        //    list_string.Add('a');
        //}
        //timer.Stop();
        //Console.WriteLine("listChar " + timer.ElapsedMilliseconds + " " + list_string.Count());

        //for (UInt64 n = 1025; n < N; n += 500000)
        //{
        //    timer.Restart();
        //    StringBuilder stringBuilder = new StringBuilder();
        //    for (UInt64 i = 0; i < n; i++)
        //    {
        //        stringBuilder.Append("a");
        //    }
        //    timer.Stop();
        //    Console.WriteLine("StringBuilder " + timer.ElapsedMilliseconds);
        //    Console.WriteLine($"длина строки {stringBuilder.Length} \n объем памяти {stringBuilder.Capacity}");
        //}

        ////Взять подстроку
        //Random rnd = new Random();
        //StringBuilder random_stringBuilder = new StringBuilder();
        //for (UInt64 i = 0; i < 20; i++)
        //{
        //    char c = Convert.ToChar(rnd.Next('a', 'z'));
        //    random_stringBuilder.Append(c);
        //}
        //Console.WriteLine(random_stringBuilder);
        ////string s = random_stringBuilder.ToString();
        //Console.WriteLine(s.Substring(2, 5));

        //string s1 = "мама";
        //string s2 = "мама";
    }
}