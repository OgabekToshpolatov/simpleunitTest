// See https://aka.ms/new-console-template for more information


    Problems person = new Problems();
    var list = Console.ReadLine()?.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
     var result = person.GetClock(list[0],list[1]);
     System.Console.WriteLine(result.Item1+" "+result.Item2);

public class Problems
{   public  Tuple<int,int> GetClock(int a, int b)
    {
        if(b>=45)
                 return Tuple.Create(a,(b-45));
            
        else
        {
           b=45-b;
           if(a==0)
            {
                a=24;
                return Tuple.Create((a-1),(60-b));
            }

            else 
                return Tuple.Create((a-1),(60-b));     
        }         

    }
}
