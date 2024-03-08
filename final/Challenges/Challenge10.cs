namespace csharp.basic
{
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            int longitud = palabra.Length;
            Console.WriteLine($"La longitud de la palabra \"{palabra}\" es: {longitud}");
        }
       
    }
     
}