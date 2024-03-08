namespace csharp.basic
{
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int radio = int.Parse(Console.ReadLine());
            int decimales = 2;
            double res = 2 * Math.PI * radio;
            double redondeado = Math.Round(res, decimales);
            Console.WriteLine(redondeado);
        }
       
    }
     
}