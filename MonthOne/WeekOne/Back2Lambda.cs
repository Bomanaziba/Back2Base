


namespace WeekOne;

public class Back2Lambda
{

    public delegate int Transformer(int x);

    public static readonly Transformer sqr = x => x * x;



    
}