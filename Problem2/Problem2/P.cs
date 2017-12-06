using System.Linq;

class P
{
    static void Main()
    {
        var f = new int[99];
        var i = f[0] = 1;
        f[1] = 2;

        while (f[i] < 4000000)
            f[i + 1] = f[i] + f[i++ - 1];

        System.Console.Write(f.Sum(x => x % 2 == 0 ? x : 0));
    }
}
// 171 bytes minified