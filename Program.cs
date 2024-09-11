// See https://aka.ms/new-console-template for more information
using WeekOne;

Console.WriteLine("Hello, World!");


//Delegates 1
//Transformer t = Square;
//int result = t(3);
//Console.WriteLine(result);

//Action<int> p = Back2Delegates.WriteProgressToConsole;
//p += Back2Delegates.WriteLineProgressToFile;

//Back2Delegates.HardWork(p);

//Back2Delegates.TransformAll(3, new Squarer());

//Back2Delegates.StringAction sa = Test.ActOnObject;


//Events

//Back2Events.Stock stock = new Back2Events.Stock("THPW");
//stock.Price = 27.10M;
//stock.Price = 31.59M;


//Lambda Expression
//Console.WriteLine(Back2Lambda.sqr(5));

Action[] actions = new Action[3];

for (int i = 0; i < 3; i++)
    actions [i] = () => Console.Write (i); 
    
foreach (Action a in actions) 
    a(); // 333


static void stock_PriceChanged(object sender, EventArgs e)
{
    //decimal increase = (e.LastPrice != 0)?(e.NewPrice - e.LastPrice)/e.LastPrice:e.NewPrice/e.NewPrice;

    //if(increase > 0.1M)
    //{
      //  Console.WriteLine("Alert, {0}% stock price increase!", Math.Round(increase*100, 2));
    //}

    Console.WriteLine("Alert Price Changed!");
}
