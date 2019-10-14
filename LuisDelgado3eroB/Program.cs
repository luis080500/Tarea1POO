using System;

namespace LuisDelgado3eroB
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean seguir = true;
            int opcion;

            do
            {
                Console.WriteLine("TAREA 1 - PRIMER PARCIAL");
                Console.WriteLine("Seleccione el numero de ejercicio a realizar");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("Ejercicio " + i);
                }
                Console.WriteLine("Salir 11");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        new Program().Ejercicio1();
                        break;
                    case 2:
                        new Program().Ejercicio2();
                        break;
                    case 3:
                        new Program().Ejercicio3();
                        break;
                    case 4:
                        new Program().Ejercicio4();
                        break;
                    case 5:
                        new Program().Ejercicio5();
                        break;
                    case 6:
                        new Program().Ejercicio6();
                        break;
                    case 7:
                        new Program().Ejercicio7();
                        break;
                    case 8:
                        new Program().Ejercicio8();
                        break;
                    case 9:
                        new Program().Ejercicio9();
                        break;
                    case 10:
                        new Program().Ejercicio10();
                        break;

                    case 11:
                        seguir = false;
                        break;
                }

            } while (seguir);

        }

        public void Ejercicio1()
        {
            Console.WriteLine("NÚMERO MAYOR");
            Console.WriteLine("Ingrese un número");
            int numero;
            string resultado;
            resultado = Console.ReadLine();
            numero = int.Parse(resultado);
            do
            {
                Console.WriteLine("Ingresar otro número o escriba para finalizar Salir?");
                resultado = Console.ReadLine();
                if (resultado != "Salir")
                { if (int.Parse(resultado) > numero)
                    {
                        numero = int.Parse(resultado);
                    }
                }
            } while (resultado != "Salir");
            Console.WriteLine("El número mayor ingresado es: " + numero);
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio2()
        {
            Console.WriteLine("CUADRADO");
            Console.WriteLine("Ingrese la dimensión de un lado de su cuadrado");
            int dimension = 0;
            dimension = int.Parse(Console.ReadLine());


            string perimetro = "*", espacio = " ";
            for (int i = 0; i < dimension; i++)
            {
                if (i == 0) {
                    for (int f = 0; f < dimension; f++)
                    {
                        Console.Write(perimetro);
                        Console.Write(espacio);
                    }
                    Console.WriteLine("");
                }
                if (i != 0 && i != dimension - 1)
                {
                    Console.Write(perimetro);
                    for (int f = 0; f < (dimension * 2) - 3; f++)
                    {
                        Console.Write(espacio);
                    }
                    Console.Write(perimetro);
                    Console.WriteLine();
                }
                if (i == dimension - 1)
                {
                    for (int g = 0; g < dimension; g++)
                    {
                        Console.Write(perimetro);
                        Console.Write(espacio);
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio3()
        {
            Console.WriteLine("FACTURA");
            double precio = 0, resultado = 0, total = 0;
            string cantidad = "0";
            do
            {
                Console.WriteLine("introduzca la cantidad de producto");
                cantidad = Console.ReadLine();
                if (cantidad != "0")
                {
                    Console.WriteLine("precio unitario");
                    precio = double.Parse(Console.ReadLine());
                    resultado = int.Parse(cantidad) * precio;
                    total = total + resultado;
                }
            }
            while (cantidad != "0");
            Console.WriteLine("valor total de la factura es:" + total);
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio4()
        {
            Console.WriteLine("SALARIO SEMANAL");
            int horas = 0, extra = 0, salario = 0;
            string continuar; 
            Console.WriteLine("Ingrese las horas de trabajadas de la semana");
            horas = int.Parse(Console.ReadLine());
            extra = horas - 35;
            horas= horas - extra;
            salario = (horas * 15) + (extra * 22);
            Console.WriteLine("Salario semanal"+salario);
            do
            {
                Console.WriteLine("Desea calcular otro salario Si o No");
                continuar = Console.ReadLine();
                if (continuar != "no")
                {
                    Console.WriteLine("Ingrese las horas de trabajadas de la semana");
                    horas = int.Parse(Console.ReadLine());
                    extra = horas - 35;
                    horas = horas - extra;
                    salario = (horas * 15) + (extra * 22);
                    Console.WriteLine("Salario semanal" + salario);
                }
            }
            while (continuar != "no");
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio5()
        {
            Console.WriteLine("PIERÁMIDE");
            int pisos = 0, total= -1, espacio=0, aterisco = 1 ;
            Console.WriteLine("Ingrese el número de pisos de la piramide");
            pisos = int.Parse(Console.ReadLine());
            for (int c = 0; c < pisos; c++)
            {
                total = total + 2;
            }
            espacio = (total - 1) / 2;

            for (int i = 0; i < pisos; i++)
            {
                for (int g = 0; g < espacio; g++)
                {
                    Console.Write(" ");
                }
                for (int g = 0; g < aterisco; g++)
                {
                    Console.Write("*");
                }

                for (int h = 0; h < espacio; h++)
                {
                    Console.Write(" ");
                }
                espacio = espacio - 1;
                aterisco = aterisco + 2;
                Console.Write("\n");

            }
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio6()
        {
            Console.WriteLine("ROMBO");
            int tamaño, extension = -1, espacio, aterisco = 1, inferior;
            Console.WriteLine("Ingrese el tamaño para el rombo");
            tamaño = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < tamaño; i++)
            {
                extension = extension + 2;
            }
            inferior = extension - 2;
            espacio = (extension - 1) / 2;
            for (int i = 0; i < tamaño; i++)
            {
                for (int c = 0; c < espacio; c++)
                {
                    Console.Write(" ");
                }
                for (int g = 0; g < aterisco; g++)
                {
                    Console.Write("*");
                }
                for (int f = 0; f < espacio; f++)
                {
                    Console.Write(" ");
                }
                espacio = espacio - 1;
                aterisco = aterisco + 2;
                Console.Write("\n");
            }
            aterisco = inferior;
            espacio = 1;
            for (int i = tamaño; i > 0; i--)
            {
                for (int c = 0; c < espacio; c++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < aterisco; c++)
                {
                    Console.Write("*");
                }
                for (int c = 0; c < espacio; c++)
                {
                    Console.Write(" ");
                }
                espacio = espacio + 1;
                aterisco = aterisco - 2;
                Console.Write("\n");
            }
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio7()
        {
            Console.WriteLine("COLUMNA DE NUMEROS DEL 1 AL 100 Y DEL 100 AL 1");
            
            int contador = 100;
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + "   " + contador + "\n");
                contador--;
            }
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio8()
        {
            Console.WriteLine("CONTADOR DE NUMEROO DE UNO EN UNO, DE DOS EN DOS, Y DE TRES EN TRES");  
            int numero = 0, dos, tres;
            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());
            dos = numero;
            tres = numero;
            while (dos > 0 && tres>0)
            {
                dos = dos - 2;
                tres = tres - 3;
            }
            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i + "  ");
                if (dos <= numero)
                {
                    Console.Write(dos + "  ");
                    dos = dos + 2;
                }
                if (tres <= numero)
                {
                    Console.Write(tres + "\n");
                    tres = tres + 3;
                }
                else
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio9()
        {
            Console.WriteLine("TABLAS DE MULTIPLICAR DEL 1 AL 15");
            {
                for (int i = 1; i < 16; i++)
                {
                    Console.WriteLine("Tabla de multiplicar del   " +i);

                    for (int c = 0; c < 13; c++)
                    {
                        Console.WriteLine(i + "*" + c + "= " + (i * c));
                    }
                }
             
            }
            Console.WriteLine("Presione cualquier tecla para acceder al menú principal");
            Console.ReadKey();
        }
        public void Ejercicio10()
        {
            Console.WriteLine("MENÚ");
            int opcion;
            Boolean condicion = true;
            do
            {
                Console.WriteLine("Escoja una opcion");
                Console.WriteLine("1)Salir\n2)Sumatorio\n3)Factorial\n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        condicion = false;
                        break;
                    case 2:
                        new Program().sumatorio();
                        break;
                    case 3:
                        new Program(). factorial();
                        break;
                }           
            } while (condicion);
        }
        public void sumatorio()
        {
            int data, sumatorio;
            Console.WriteLine("Ingrese un numero para realizar el sumatorio");
            data = int.Parse(Console.ReadLine());
            sumatorio = (data * (data + 1)) / 2;
            Console.WriteLine("El resultado del sumatorio es: " + sumatorio);
        }
        public void factorial()
        {
            int data, factorial = 1;
            Console.WriteLine("Ingrese un numero para realizar el factorial");
            data = int.Parse(Console.ReadLine());
            for (int i = 1; i <= data; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El resultado del factorial es: " + factorial);

        }
    }
}
