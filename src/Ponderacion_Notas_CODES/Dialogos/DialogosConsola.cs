/*
 *          C O D E S
 *   Comunidad de Estudiantes
 *   Informáticos de IPLACEX 
 * 
 *   Calculadora de Promedios de Notas
 *   Proyecto de Código Abierto
 * 
 *   Desarrollado por Francisco Mendezy
 *   Basado en el código de Paulina Tenorio
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponderacion_Notas_CODES.Dialogos
{
    public static class DialogosConsola
    {
        public static void CargarDialogosOpt1()
        {
            Console.Clear();
            Header();
            double nota1, foro1, nota2, foro2, nota3, foro3, notae;

            // Pedir al usuario las notas y los foros para la Unidad I
            Console.WriteLine("=== UNIDAD I ===");
            nota1 = LeerNota("Ingresa la nota de la primera evaluación (ejemplo: 5.4): ");
            foro1 = LeerNota("Ingresa la nota del foro 1: ");

            // Pedir al usuario las notas y los foros para la Unidad II
            Console.WriteLine("\n=== UNIDAD II ===");
            nota2 = LeerNota("Ingresa la nota de la segunda evaluación: ");
            foro2 = LeerNota("Ingresa la nota del foro 2: ");

            // Pedir al usuario las notas y los foros para la Unidad III
            Console.WriteLine("\n=== UNIDAD III ===");
            nota3 = LeerNota("Ingresa la nota de la tercera evaluación: ");
            foro3 = LeerNota("Ingresa la nota del foro 3: ");

            // Pedir al usuario la nota del examen
            Console.WriteLine("\n=== ÉXAMEN ===");
            notae = LeerNota("Ingrese la nota de tu examen: ");

            // Calcular la ponderación - Por Paulina Tenorio
            double notaFinal = nota1 * 0.15 + foro1 * 0.05 +
                               nota2 * 0.15 + foro2 * 0.05 +
                               nota3 * 0.15 + foro3 * 0.05 +
                               notae * 0.4;

            // Mostrar el promedio y el mensaje de aprobación/reprobación
            Console.WriteLine($"\n\u001b[38;5;208mRESULTADO:\u001b[37m El promedio de tus notas es: {notaFinal:N1} {(notaFinal >= 4.0 ? "\u001b[32m(Aprobado)\u001b[37m" : "\u001b[31m(Reprobado)\u001b[37m")}");
        }

        public static void CargarDialogosOpt2()
        {
            Console.Clear();
            Header();
            //double nota1, foro1, nota2, foro2, nota3, foro3, notae;
            Console.WriteLine("Selecciona en que etapa te encuentras:");
            Console.WriteLine("1. Cursando Unidad I");
            Console.WriteLine("2. Cursando Unidad II");
            Console.WriteLine("3. Cursando Unidad III");
            Console.WriteLine("4. Cursando el Examen");

            int opt = Convert.ToInt32(Console.ReadLine());
            double nota1, foro1, nota2, foro2, nota3, foro3;
            switch (opt)
            {
                case 1:
                    Console.Clear();
                    Header();
                    Console.WriteLine("Debes tener notas para que pueda hacer los calculos.\nCuando estés en la Unidad II y tengas las notas de la Unidad I, vuelve a consultarme.");
                    break;
                case 2:
                    Console.Clear();
                    Header();
                    // Pedir al usuario las notas y los foros para la Unidad I
                    Console.WriteLine("=== UNIDAD I ===");
                    nota1 = LeerNota("Ingresa la nota de la primera evaluación (ejemplo: 5.4): ");
                    foro1 = LeerNota("Ingresa la nota del foro 1: ");
                    double notaFinal2 = (nota1 + foro1) / 2;
                    // Mostrar el promedio y el mensaje de aprobación/reprobación
                    Console.WriteLine($"\n\u001b[38;5;208mRESULTADO:\u001b[37m El promedio de tus notas hasta el momento es: {notaFinal2:N1} {(notaFinal2 >= 4.0 ? "\u001b[32m(Aprobado)\u001b[37m" : "\u001b[31m(Reprobado)\u001b[37m")}");
                    break;
                case 3:
                    Console.Clear();
                    Header();
                    // Pedir al usuario las notas y los foros para la Unidad I
                    Console.WriteLine("=== UNIDAD I ===");
                    nota1 = LeerNota("Ingresa la nota de la primera evaluación (ejemplo: 5.4): ");
                    foro1 = LeerNota("Ingresa la nota del foro 1: ");
                    // Pedir al usuario las notas y los foros para la Unidad II
                    Console.WriteLine("\n=== UNIDAD II ===");
                    nota2 = LeerNota("Ingresa la nota de la segunda evaluación: ");
                    foro2 = LeerNota("Ingresa la nota del foro 2: ");
                    double notaFinal3 = (nota1 + foro1 + nota2 + foro2) / 4;
                    // Mostrar el promedio y el mensaje de aprobación/reprobación
                    Console.WriteLine($"\n\u001b[38;5;208mRESULTADO:\u001b[37m El promedio de tus notas hasta el momento es: {notaFinal3:N1} {(notaFinal3 >= 4.0 ? "\u001b[32m(Aprobado)\u001b[37m" : "\u001b[31m(Reprobado)\u001b[37m")}");
                    break;
                case 4:
                    Console.Clear();
                    Header();
                    // Pedir al usuario las notas y los foros para la Unidad I
                    Console.WriteLine("=== UNIDAD I ===");
                    nota1 = LeerNota("Ingresa la nota de la primera evaluación (ejemplo: 5.4): ");
                    foro1 = LeerNota("Ingresa la nota del foro 1: ");
                    // Pedir al usuario las notas y los foros para la Unidad II
                    Console.WriteLine("\n=== UNIDAD II ===");
                    nota2 = LeerNota("Ingresa la nota de la segunda evaluación: ");
                    foro2 = LeerNota("Ingresa la nota del foro 2: ");
                    // Pedir al usuario las notas y los foros para la Unidad III
                    Console.WriteLine("\n=== UNIDAD III ===");
                    nota3 = LeerNota("Ingresa la nota de la tercera evaluación: ");
                    foro3 = LeerNota("Ingresa la nota del foro 3: ");
                    double notaFinal4 = (nota1 + foro1 + nota2 + foro2 + nota3 + foro3) / 6;
                    // Mostrar el promedio y el mensaje de aprobación/reprobación
                    Console.WriteLine($"\n\u001b[38;5;208mRESULTADO:\u001b[37m El promedio de tus notas hasta el momento es: {notaFinal4:N1} {(notaFinal4 >= 4.0 ? "\u001b[32m(Aprobado)\u001b[37m" : "\u001b[31m(Reprobado)\u001b[37m")}");
                    break;
            }
        }

        /*
        public static void CargarDialogosOpt3()
        {
            // PROXIMAMENTE
        }
        */

        public static void CargarDialogosOpt9()
        {
            Console.Clear();
            Header();
            Console.WriteLine("Esta aplicación fue creada en C# para la Comunidad CODES");
            Console.WriteLine("Desarrollado por Francisco Mendezy con los códigos de ponderación de Paulina Tenorio originalmente creados en Python.");
            Console.WriteLine("\n¡Gracias por usar nuestra App, esperamos que te sea de útilidad!");
        }

        /*
         * Header de la App: Nombre y Versión Actual
         */
        public static void Header()
        {
            Console.WriteLine("\u001b[38;5;15mCalculadora de Promedios de Notas - \u001b[38;5;208mC\u001b[38;5;214mO\u001b[38;5;208mD\u001b[38;5;220mE\u001b[38;5;214mS\u001b[38;5;15m");
            Console.WriteLine("Ver. 1.0.0 pub\n");
        }

        static double LeerNota(string mensaje)
        {
            double nota = 0.0; // Inicializa con un valor por defecto

            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();

                if (double.TryParse(entrada, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out nota))
                {
                    if (nota >= 0.0 && nota <= 7.0)
                    {
                        return nota;
                    }
                    else
                    {
                        Console.WriteLine("\u001b[31mNota fuera de rango. Por favor, ingresa una nota válida entre 0.0 y 7.0.\u001b[37m\n");
                    }
                }
                else
                {
                    Console.WriteLine("\u001b[31mNota no válida. Por favor, ingresa una nota válida en formato decimal (ejemplo: 6.5).\u001b[37m\n");
                }
            }
        }
    }
}
