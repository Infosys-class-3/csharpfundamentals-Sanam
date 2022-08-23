class OddEven
{
     internal void checkOddEven()
    { 
        int num = 10;
        if (num % 2 == 0)
        {
            Console.WriteLine("Print number is Even");
        }
        else
        {
            Console.WriteLine("Print number is Odd");
        }
    }
    internal void SimpleInterest()
    {
        int p=110;
        int t=10;
        int r=10;
        int simpleinterest=p*t*r/100;
        
    }

class Main1
{
    public static void Main()
    {
        OddEven obj1=new();
        obj1.checkOddEven();
        obj1.SimpleInterest();
        

    }

}

}
