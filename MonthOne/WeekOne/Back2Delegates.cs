using System;

namespace WeekOne;

//Delegates
public class Back2Delegates
{
    public delegate void StringAction(string s);

    public delegate int Transformer(int x);

    public delegate void ProgressReporter(int percentComplete);

    public delegate TResult Func<out TResult>();

    public delegate TResult Func<in T, out TResult>(T arg);

    public delegate void Action();

    public delegate void Action<in T>(Task a);

    public static int Square(int x) => x * x; 

    public static void HardWork(System.Action<int> p)
    {
        for(int i = 0; i <= 10; i++)
        {
            p(i * 10);
            System.Threading.Thread.Sleep(100);
        }
    }

    public static void TransformAll(int x, ITransformer p)
    {
        Console.WriteLine(p.Transformer(x));
    }

    public static void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);

    public static void WriteLineProgressToFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

}

public interface ITransformer
{
    int Transformer(int x);
}


public class Squarer : ITransformer
{
    public int Transformer(int x) => x * x;
}


public class Test
{
    public static void ActOnObject(object o) => Console.WriteLine(o);
}

