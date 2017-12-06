    class C
    {
        static void Main()
        {
            int i = 0, s = 0;
            while (i++ < 999)
                s += i % 3 == 0 || i % 5 == 0 ? i : 0;
            System.Console.Write(s);
        }
    }
// 105 bytes minified