
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
        if(a == null || !a.Any())
        {
            return default;
        }

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

}