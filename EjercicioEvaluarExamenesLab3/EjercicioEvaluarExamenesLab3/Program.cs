using System;
using System.Collections;

namespace EjercicioEvaluarExamenesLab3
{
    class Evaluador
    {
        static void Main(string[] args)
        {
            int cantPreg, cantOpcionesResp;
            string cantOpcionesRespString, cantPregString;

            Console.WriteLine("Ingrese la cantidad de preguntas: ");
            cantPregString = Console.ReadLine();

            if (int.TryParse(cantPregString, out cantPreg))
            {
               
            }
            else Console.WriteLine("Debe ingresar un valor numerico");

            Console.WriteLine("\nIngrese la cantidad de respuestas por pregunta: ");
            cantOpcionesRespString = Console.ReadLine();

            if (int.TryParse(cantOpcionesRespString, out cantOpcionesResp))
            {

            }                
            else Console.WriteLine("Debe ingresar un valor numerico");

            string[] preguntas = new string[cantPreg];
            string[,] opcionesRespuestas = new string[cantPreg, cantOpcionesResp];
            int[] respuestasCorrectas = new int[cantPreg];
            int[] respuestasUsuario = new int[cantPreg];

            for (int i = 0; i < cantPreg; i++)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine($"\nIngrese la pregunta n° |{i + 1}|:");
                preguntas[i] = Console.ReadLine();

                for (int j = 0; j < cantOpcionesResp; j++)
                {
                    Console.WriteLine($"\nIngresa la opcion de respuesta |{j + 1}| para la pregunta |{i + 1}|:");
                    opcionesRespuestas[i, j] = Console.ReadLine();
                }

                Console.WriteLine($"\nNúmero de la respuesta correcta de la pregunta |{i + 1}|:");
                int respuestaCorrecta;

                while (!int.TryParse(Console.ReadLine(), out respuestaCorrecta) || respuestaCorrecta < 1 || respuestaCorrecta > cantOpcionesResp)
                {
                    Console.WriteLine($"Ingrese un número entre |1| y |{cantOpcionesResp}| para la pregunta |{i + 1}|:");
                }
                respuestasCorrectas[i] = respuestaCorrecta -1;
            }
            Console.WriteLine("\n\tDATOS CARGADOS CORRECTAMENTE");
            Console.WriteLine("\nPresione alguna tecla para realizar evaluación...\n");
            Console.ReadKey();

            Console.WriteLine("\n\n***************************************************");
            Console.WriteLine("   INDIQUE CON UN NUMERO LA RESPUESTA CORRECTA");
            Console.WriteLine("***************************************************");

            for (int i = 0; i < cantPreg; i++)
            {
                Console.WriteLine(preguntas[i]);

                for (int j = 0; j < cantOpcionesResp; j++)
                {
                    Console.WriteLine($"\n{j + 1}) " + opcionesRespuestas[i, j]);                    
                }   
                    respuestasUsuario[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < cantPreg; i++)
            {
                if (respuestasUsuario[i] == (respuestasCorrectas[i]+1))
                {
                    Console.WriteLine($"\n{i +1}) La respuesta '{opcionesRespuestas[i, respuestasCorrectas[i]]}' es correcta.");
                }
                else Console.WriteLine($"\n{i +1}) Respuesta incorrecta. La respuesta correcta es: '{opcionesRespuestas[i, respuestasCorrectas[i]]}'");
            }






        }
    }
}