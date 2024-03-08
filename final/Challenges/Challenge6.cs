namespace csharp.basic
{
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = double.Parse(Console.ReadLine());
            if(salario > 12000)
            {
                double excedente = salario - 12000;
                double impuesto = excedente * 0.15;
                Console.WriteLine($"El impuesto a pagar es: {impuesto}");
            }
            else Console.WriteLine("No debe impuestos.");
            

        }
       
    }
     
}