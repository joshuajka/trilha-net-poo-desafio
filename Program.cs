using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("135456468", "oracle", "fsdanhkjcdas231jb3124v", 4);
        Iphone iphone = new Iphone("13545643468", "5SE", "fsdanhkjcda421324jb3124v", 16);

        nokia.InstalarAplicativo("Waze");
        iphone.InstalarAplicativo("Uber");
    }
}