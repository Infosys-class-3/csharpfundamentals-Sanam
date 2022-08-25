using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Method a = new();
        var Out = a.GetData("Sanam", "Thapa" ,"Katunje, 04 Bhaktapur");
        Console.WriteLine(Out);
        Console.WriteLine(a.GetCreatedDateTime());
        var Output=a.GetDetails(firstname: "Sanam", lastname: "Thapa", faculty: " Computer Science", height:"179cm");
        Console.WriteLine(Output);
 
    }
    


}