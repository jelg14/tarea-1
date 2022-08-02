using System;
    class Program
    {
        static void Main(string[] args)
        {
        //ValidacionMayorDeEdad();
        CalculoIGGS();
        }

    static void CalculoIGGS()
    {
        const decimal IGSS = 4.86M;
        Console.WriteLine("ingrese su salario: ");

        decimal salario = Convert.ToDecimal(Console.ReadLine()); 
        decimal pagoIGGSS = decimal.Round(salario * (IGSS / 100), 2);
        Console.WriteLine("Usted paga: " + pagoIGGSS + " Q de IGSS");
        
        salario = salario - pagoIGGSS;
        Console.WriteLine("salario actual: "+salario);

        if (pagoIGGSS > 1000){
            salario = salario + 1500;
            Console.WriteLine("se le ha acreditado un bono de 1500, su salario es ahora de: " + salario + " Q");
        } else {
            salario = salario + 2500;
            Console.WriteLine("se le ha acreditado un bono de 2500, su salario ahora es de: " + salario + " Q");
        } 

        //si paga mas de 1000 de igss que se le de un boono de 1500 de lo contrario 2500
    }

    static void ValidacionMayorDeEdad()
        {   
            const int mayorDeEdad = 18;
            Console.WriteLine("Ingreso a discoteca");
            Console.WriteLine("¿Cual es su edad?, ingrese un numero");

            int edad = Convert.ToInt32(Console.ReadLine()); // toma el dato de entrada y lo convierte a un digito
            if (esMayorDeEdad(edad, mayorDeEdad)) Console.WriteLine("BIENVENIDO, puede ingresar!!! ");
            else Console.WriteLine("Lo sentimos, no puede ingresar... ");
        }

        static bool esMayorDeEdad(int edad, int edadMinima)
        {
            if (edad >= edadMinima) return true;
            else return false;
        }
}

