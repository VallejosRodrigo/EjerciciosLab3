using System;

namespace ejercicioOperacionesLab3
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            double entrada1, entrada2, suma, resta, mult, div, resto;
            string numCorto, seleccion, entrada1String, entrada2String;
            int seleccionEntero;

            Console.WriteLine("Ingrese dos numeros:\n");
            entrada1String = Console.ReadLine();
            entrada2String = Console.ReadLine();

            if (double.TryParse(entrada1String, out entrada1) && double.TryParse(entrada2String, out entrada2))
            {
                Console.WriteLine();

                Console.WriteLine("¿Que operacion desearia realizar? Ingrese una opcion numerica: ");
                Console.WriteLine($"\t1: SUMAR ({entrada1} + {entrada2})");
                Console.WriteLine($"\t2: RESTAR ({entrada1} - {entrada2})");
                Console.WriteLine($"\t3: MULTIPLICAR ({entrada1} * {entrada2})");
                Console.WriteLine($"\t4: DIVIDIR ({entrada1} / {entrada2})");
                Console.WriteLine($"\t5: RESTO ({entrada1} % {entrada2})");
                seleccion = Console.ReadLine();

                if (int.TryParse(seleccion, out seleccionEntero))
                {
                    switch (seleccionEntero)
                    {
                        case 1:
                            //suma
                            suma = entrada1 + entrada2;
                            Console.WriteLine($"SUMA: | {suma} |");
                            ; break;
                        case 2:
                            //resta
                            resta = entrada1 - entrada2;
                            Console.WriteLine($"RESTA: | {resta} |");
                            break;
                        case 3:
                            //multiplicacion
                            mult = entrada1 * entrada2;
                            Console.WriteLine($"MULTIPLICACION: | {mult} |");
                            break;
                        case 4:

                            //division
                            if ((entrada1 != 0) && (entrada2 != 0))
                            {
                                div = entrada1 / entrada2;
                                numCorto = div.ToString("N2");

                                Console.WriteLine($"DIVISION: | {numCorto} |");
                            }
                            else
                                Console.WriteLine("No se puede dividir por 0 ");
                            break;
                        case 5:
                            //resto
                            resto = entrada1 % entrada2;
                            Console.WriteLine($"RESTO: | {resto} |");
                            break;
                    }
                }
                else Console.WriteLine("Debe ingresar uno de los 5 numeros.");
            }
            else Console.WriteLine("Debe ingresar valores numericos.");
          

            


        }
    }
}