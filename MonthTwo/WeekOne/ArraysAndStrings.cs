
namespace Back2Base.MonthTwo.WeekOne;

public class ArraysAndStrings
{
    
    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static List<int> reverseArray(List<int> a)
    {
        if(a == null || !a.Any()) return default;

        int j = 0;

        for(int i = a.Count() - 1; i >= 0; i--)
        {
            if(i == j || i < j) return a;
            int temp = a[j];
            a[j] = a[i];
            a[i] = temp;
            j++;
        }

        return a;
    }


    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<int>[] arr = new List<int>[n];
        List<int> ansArr = new();

        int lastAnswer = 0;

        for(int i = 0; i < queries.Count; i++)
        {
            switch(queries[i][0])
            {
                case 1:
                    var qRes1 = Query1xY(queries[i][1], queries[i][2], lastAnswer,n);
                    if(arr[qRes1.Item1] == null)
                    {
                        arr[qRes1.Item1] = new List<int>{qRes1.Item2};
                    }else
                    {
                        arr[qRes1.Item1].Add(qRes1.Item2);
                    }
                    break;
                case 2:
                    var qRes2 = Query2xY(queries[i][1], queries[i][2], ref lastAnswer, n, arr);
                    ansArr.Add(qRes2.Item2);
                    break;
            }
        }

        return ansArr;
    }

    static (int,int) Query1xY (int x, int y, int lastAnswer, int n)
    {
        var idx = IdX(x, lastAnswer, n);

        return (idx, y);
    }

    static (int,int) Query2xY (int x, int y, ref int lastAnswer, int n, List<int>[] arr)
    {
    
        var idx = IdX(x, lastAnswer, n);

        lastAnswer = arr[idx][(y%(arr[idx].Count))];
        
        return (idx, lastAnswer);
    }

    static int IdX (int x, int lastAnswer, int n) => (x ^ lastAnswer) % n;

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        List<int> arrAns = new();

        for(int i = 0; i < arr.Count; i++)
        {
            int temp0 = arr[i];

            //TODO: get the new index to replace value
            int j = ManipulateIndex(i, arr.Count, d);

            int temp1 = arr[j];

            //arrAns.Add(temp1);
            arr[i] = temp1;
            arr[j] = temp0;
        }

        return arr;
    }

    static int ManipulateIndex(int i, int n, int d)
    {
        
        int j = i-d;

        if(i >= n/2)
        {
           j = n-1-d;
        }

        if(j < 0)
        {
            return n-1+j;
        }

        return j;
    }

}