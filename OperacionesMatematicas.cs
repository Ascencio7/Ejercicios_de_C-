using System;

class OperacionesMatematicas{
    public static void Main(){
        // Declarar las variables a usar
        double num1, num2, resultado;
        int opcion = 0;

        while(opcion != 5){
            Console.WriteLine("\nMenu de operaciones matemáticas");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");
            
            if(int.TryParse(Console.ReadLine(), out opcion))
            {
                if(opcion >= 1 && opcion <= 4)
                {
                    Console.Write("\nIngresa el primer numero: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingresa el segundo numero: ");
                    num2 = double.Parse(Console.ReadLine());

                    switch(opcion)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine("\nResultado de la suma: " + resultado);
                            break;
                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine("\nResultado de la resta: " + resultado);
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine("\nResultado de la multiplicación: " + resultado);
                            break;
                        case 4:
                            if(num2!= 0)
                            {
                                resultado = num1 / num2;
                                Console.WriteLine("\nResultado de la división: " + resultado);
                            }
                            else
                            {
                                Console.WriteLine("\nError: No se puede dividir por cero.");
                            }
                            break;
                    }
                }
                else if(opcion == 5)
                {
                    Console.WriteLine("\nFin del programa...");s
                }
                else
                {
                    Console.WriteLine("\nOpción incorrecta. Intente nuevamente.");
                }
            }
            else
            {
                Console.WriteLine("\nFin del programa...");
            }
        }
    }
}