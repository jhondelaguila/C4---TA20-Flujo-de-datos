using System;

namespace Tarea20
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
            Ejercicio11();
            Ejercicio12();
            Ejercicio13();
            Ejercicio14();
            Ejercicio15();
            Ejercicio16();
            Ejercicio17();
            Ejercicio18();
            Ejercicio19();
            Ejercicio20();
            Ejercicio21();
            Ejercicio22();
            Ejercicio23();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("\n### Ejercicio 1 ###");
            int num1 = 5, num2 = 10, num3 = 7;
            int suma = num1 + num2 + num3;
            Console.WriteLine("La suma de los números es: " + suma);
        }

        static void Ejercicio2()
        {
            Console.WriteLine("\n### Ejercicio 2 ###");
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa una ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }

        static void Ejercicio3()
        {
            Console.WriteLine("\n### Ejercicio 3 ###");
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("\n### Ejercicio 4 ###");
            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine(num1 + " es mayor que " + num2);
            else if (num2 > num1)
                Console.WriteLine(num2 + " es mayor que " + num1);
            else
                Console.WriteLine("Los números son iguales");
        }

        static void Ejercicio5()
        {
            Console.WriteLine("\n### Ejercicio 5 ###");
            Console.Write("Ingresa el nombre de la semana: ");
            string diaSemana = Console.ReadLine().ToLower();

            if (diaSemana == "sábado" || diaSemana == "domingo")
                Console.WriteLine("Es fin de semana");
            else
                Console.WriteLine("No es fin de semana");
        }

        static void Ejercicio6()
        {
            Console.WriteLine("\n### Ejercicio 6 ###");
            Console.Write("Ingresa el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Forma de pago (efectivo o tarjeta): ");
            string formaPago = Console.ReadLine();

            if (formaPago.ToLower() == "tarjeta")
            {
                Console.Write("Ingresa el número de cuenta: ");
                string numeroCuenta = Console.ReadLine();
            }

        }

        static void Ejercicio7()
        {
            Console.WriteLine("\n### Ejercicio 7 ###");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejercicio8()
        {
            Console.WriteLine("\n### Ejercicio 8 ###");
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Ejercicio9()
        {
            Console.WriteLine("\n### Ejercicio 9 ###");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejercicio10()
        {
            Console.WriteLine("\n### Ejercicio 10 ###");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ejercicio11()
        {
            Console.WriteLine("\n### Ejercicio 11 ###");
            int num1 = 8, num2 = 8;

            if (num1 > num2)
                Console.WriteLine(num1 + " es mayor que " + num2);
            else if (num2 > num1)
                Console.WriteLine(num2 + " es mayor que " + num1);
            else
                Console.WriteLine("Los números son iguales");
        }

        static void Ejercicio12()
        {
            string nombre = "Jhon";
            Console.WriteLine("\n### Ejercicio 12 ###");
            Console.Write("Ingresa tu nombre: ");
            Console.WriteLine("Bienvenido " + nombre);
        }

        static void Ejercicio13()
        {
            Console.WriteLine("\n### Ejercicio 13 ###");
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
        }

        static void Ejercicio14()
        {
            Console.WriteLine("\n### Ejercicio 14 ###");
            Console.Write("Ingresa el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El área del círculo es: " + area);
        }

        static void Ejercicio15()
        {
            Console.WriteLine("\n### Ejercicio 15 ###");
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine(numero + " es divisible entre 2.");
            else
                Console.WriteLine(numero + " no es divisible entre 2.");
        }

        static void Ejercicio16()
        {
            Console.WriteLine("\n### Ejercicio 16 ###");
            const double IVA = 0.21;

            Console.Write("Ingresa el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            double precioConIva = precio * (1 + IVA);
            Console.WriteLine("El precio con IVA es: " + precioConIva);
        }

        static void Ejercicio17()
        {
            Console.WriteLine("\n### Ejercicio 17 ###");
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Ejercicio18()
        {
            Console.WriteLine("\n### Ejercicio 18 ###");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejercicio19()
        {
            Console.WriteLine("\n### Ejercicio 19 ###");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ejercicio20()
        {
            Console.WriteLine("\n### Ejercicio 21 ###");
            Console.Write("Ingresa el número de ventas: ");
            int numVentas = Convert.ToInt32(Console.ReadLine());
            double totalVentas = 0;

            for (int i = 1; i <= numVentas; i++)
            {
                Console.Write("Ingresa la venta " + i + ": ");
                double venta = Convert.ToDouble(Console.ReadLine());
                totalVentas += venta;
            }

            Console.WriteLine("La suma total de ventas es: " + totalVentas);
        }

        static void Ejercicio21()
        {
            Console.WriteLine("\n### Ejercicio 21 ###");
            Console.Write("Ingresa un día de la semana: ");
            string diaSemana = Console.ReadLine().ToLower();

            switch (diaSemana)
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un día laboral.");
                    break;
                case "sábado":
                case "domingo":
                    Console.WriteLine("No es un día laboral.");
                    break;
                default:
                    Console.WriteLine("Día no reconocido.");
                    break;
            }
        }

        static void Ejercicio22()
        {
            string contrasena = "secreto";
            int intentos = 3;
            Boolean correcto = false;

            while (intentos > 0 && correcto == false)
            {
                Console.Write("Ingresa la contraseña: ");
                string entrada = Console.ReadLine();

                if (entrada == contrasena)
                {
                    Console.WriteLine("Enhorabuena");
                    correcto = true;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Contraseña incorrecta. Intentos restantes: " + intentos);
                }
            }

            if (intentos == 0)
            {
                Console.WriteLine("Se agotaron los intentos. Acceso bloqueado.");
            }
        }

        static void Ejercicio23()
        {
            Console.Write("Ingresa el primer operando: ");
            int operando1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo operando: ");
            int operando2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el signo aritmético (+, -, *, /, ^, %): ");
            string signo = Console.ReadLine();

            double resultado = 0;

            switch (signo)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = (double)operando1 / operando2;
                    break;
                case "^":
                    resultado = Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
                default:
                    Console.WriteLine("Signo aritmético no válido.");
                    break;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }

}