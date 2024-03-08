namespace csharp.basic
{
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer numero:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer numero:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto numero:");
            double num4 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"El promedio de los cuatro numeros es: {promedio}");
        }
       
    }
     
}