namespace csharp.basic
{
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if(num > 0) Console.WriteLine(Math.Sqrt(num));
            else if(num < 0) Console.WriteLine(Math.Pow(num, 2));
            else Console.WriteLine(num);
        }
       
    }
     
}