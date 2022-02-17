using System;
using System.Linq;
public class Programm
{
    int[] arrcust;
    int cash_box;
    public void customers()
    {
        Console.WriteLine("enter count of customers: ");
        string temp = Console.ReadLine();
        int count = Convert.ToInt32(temp);
        arrcust = new int[count];
        Console.WriteLine("enter count of cashboxes:");
        temp = Console.ReadLine();
        cash_box = Convert.ToInt32(temp);
        Console.WriteLine("enter service time for each customer:");
        for (int i = 0; i < arrcust.Length; i++)
        {
            temp = Console.ReadLine();
            arrcust[i] = Convert.ToInt32(temp);
        }
    }
    public static void Main()
    {
        Programm res = new Programm();
        res.customers();
        HW1.QueueTime(res.arrcust, res.cash_box);
    }
}
public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int[] inmoment = new int[n];                      
        for (int i = 0; i < n; i++)                         
        {
            inmoment[i] = customers[i];
        }
        if(n == 1)
        {
            Console.WriteLine(customers.Sum());
        }
        else { 
            for (int i = n; i < customers.Length; i++)
            {
                int min = inmoment[0];
                int temp = 0;
                for (int j = 0; j < n; j++)
                {
                    if (inmoment[j] < min)
                    {
                        min = inmoment[j];
                        temp = j;
                     }

                }
                inmoment[temp] += customers[i];
        }
            int result = inmoment[0];
            for (int j = 0; j < n; j++)
        {
                if (inmoment[j] > result)
                {
                    result = inmoment[j];
                }

            }
            Console.WriteLine(result);
         }
        return 0;
    }
}
