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
using Ponderacion_Notas_CODES.Dialogos;
using System;
using System.Globalization;

void AppCalcPonderacion()
{
    try
    {
        while (true)
        {
            Presentacion();
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    DialogosConsola.CargarDialogosOpt1();
                    Reiniciar();
                    break;

                case 2:
                    DialogosConsola.CargarDialogosOpt2();
                    Reiniciar();
                    break;

                case 9:
                    DialogosConsola.CargarDialogosOpt9();
                    Reiniciar();
                    break;

                case 0:
                    Despedida();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opción inválida");
                    Reiniciar();
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Opción inválida");
        Reiniciar();
    }
}

void Presentacion()
{
    // Configuración de la cultura regional para Chile en los valores ingresados (es-CL)
    CultureInfo culturaChilena = new CultureInfo("es-CL");
    CultureInfo.DefaultThreadCurrentCulture = culturaChilena;

    DialogosConsola.Header();
    Console.WriteLine("Elige una opcion para empezar:");
    Console.WriteLine("1. Calcular Promedio de todas las notas de un ramo.");
    Console.WriteLine("2. Calcular Promedio de Notas que llevo hasta ahora en un ramo. \u001b[38;5;208m<- \u001b[38;5;214mP\u001b[38;5;208mO\u001b[38;5;220mP\u001b[38;5;217mU\u001b[38;5;213mL\u001b[38;5;208mA\u001b[38;5;203mR\u001b[38;5;208m!\u001b[38;5;15m");
    //Console.WriteLine("3. Calcular la nota que debo tener para aprobar el ramo.");
    Console.WriteLine("\n9. Ver Créditos");
    Console.WriteLine("0. Salir");

    Console.WriteLine("\nIngresa el número de la opción:");
}

void Reiniciar()
{
    Console.WriteLine("\n\u001b[38;5;208mPresione \u001b[38;5;15mEnter\u001b[38;5;208m para volver al menú\u001b[38;5;15m");
    Console.ReadLine();
    Console.Clear();
    AppCalcPonderacion();
}

void Despedida()
{
    Console.Clear();
    DialogosConsola.Header();
    Console.WriteLine("Gracias por usar la calculadora de Ponderación de CODES.");
    Console.WriteLine("\n\n\u001b[38;5;208mPresiona Enter para salir\u001b[38;5;15m");
    Console.ReadLine();
    Environment.Exit(1);
}

AppCalcPonderacion();// Ejecuta la App - CODES