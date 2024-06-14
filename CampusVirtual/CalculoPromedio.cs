﻿#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <CalculoPromedioController>                                                                      
 * DescripciÓn   : <Controlador para registrar y mostrar el promedio de calificaciones>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <11-06-2024>                                                                             
 *                                                                                                           
 * Fecha         Autores         	Modificación                                                                 
 * ===========   ============   	=====================
 * 11-06-2024   <Pedro Castro>        1 - Version Inicial 
 * 11-06-2024   <Pedro Castro>        2 - Se modifica operacion matematica
 * 11-06-2024   <Pedro Castro>        3 - Se declaran variables
 * 12-06-2024   <Pedro Castro>        4 - Se crean variables, constantes y metodos para el calculo de horas semanales, se aplica camelCase
 * 13-06-2024   <Pedro Castro>        5 - Se agrega contador a las horas estudiantiles.
 * 13-06-2024   <Pedro Castro>        6 - Se agregan operadores logicos.
 * 13-06-2024   <Pedro Castro>        7 - Se agrega materia de string de materias cursadas.
 * 14-06-2024   <Pedro Castro>        8 - Se agrega menu de opciones.
 ***************************************************************************************************/
#endregion Documentación

/// <summary>
/// Variables para capturar e imprimir el promedio estudiantil
/// </summary>
/// <returns>listas de variables</returns>
var primerCorte = 0.0;
var segundoCorte = 0.0;
var tercerCorte = 0.0;
var cuartoCorte = 0.0;
var promedioanual = "";
var promedioSemestral = "";
var promedioSemestralInfo = "";
var materiaEnCurso = "";
var switchControl = "menu";
const int ValorDivisionSemestre = 2;
const int ValorDivisionanual = 4;

Console.WriteLine("!Bienvenido a este tu campus virtual¡");
Console.WriteLine("Para calcular tu promedio semestar por favor presiona 1\n" +
                  "Para calcular tu promedio anual por favor presiona 2 \n" +
                  "Para calcular el horario semanal estudiantil por favor presiona 3 \n" +
                  "Para calcular el horario necesario para cursar una asignatura por favor presiona 4" );
switchControl = Console.ReadLine();

/// <summary>
/// Capturar y ver detalle del promedio semestral
/// </summary>
/// <returns>listas del detalle de la solicitud del calculo del promedio semestral</returns>
switch (switchControl)
{

    case "1":
        Console.WriteLine("¿Que materia estas cursando?");
        materiaEnCurso = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Tu promedio actual semestral:");
        Console.WriteLine("Ingresa el valor de tu primer corte:");
        primerCorte = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de tu segundo corte:");
        segundoCorte = Convert.ToDouble(Console.ReadLine());
        promedioSemestral = ("Tu promedio del semestre es:" + " " + (primerCorte + segundoCorte) / (ValorDivisionSemestre));
        promedioSemestralInfo = $"Nota del primer corte:{primerCorte}\nNota del segundo corte:{segundoCorte} \nDe la materia en curso {materiaEnCurso}";

        if (primerCorte < 3 || segundoCorte < 3)
        {
            if (primerCorte != 0 && primerCorte < 3)
            {
                Console.WriteLine("Tu calificacion del primer corte:" + " " + primerCorte + " " +
                                 "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

            if (segundoCorte != 0 && segundoCorte < 3)
            {
                Console.WriteLine("Tu calificacion del segundo corte:" +
                                  " " + segundoCorte + " " + "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

        }
        else
        {
            Console.WriteLine("Tus calificaciones cumplen para aprobar el curso");
        }

        Console.WriteLine(promedioSemestralInfo);
        Console.WriteLine(promedioSemestral);
    break;

    /// <summary>
    /// Capturar y ver detalle del promedio anual
    /// </summary>
    /// <returns>listas del detalle de la solicitud del calculo del promedio anual</returns>

    case "2":
        Console.WriteLine("Tu promedio actual");
        Console.WriteLine("Ingresa el valor de tu primer corte:");
        primerCorte = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de tu segundo corte:");
        segundoCorte = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de tu tercer corte:");
        tercerCorte = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de tu cuarto corte:");
        cuartoCorte = Convert.ToDouble(Console.ReadLine());
        promedioanual = ("Tu promedio anual es:" + " " + (primerCorte + segundoCorte + tercerCorte + cuartoCorte) / (ValorDivisionanual));

        if (primerCorte < 3 || segundoCorte < 3)
        {
            if (primerCorte != 0 && primerCorte < 3)
            {
                Console.WriteLine("Tu calificacion del primer corte:" + " " + primerCorte + " " +
                                 "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

            if (segundoCorte != 0 && segundoCorte < 3)
            {
                Console.WriteLine("Tu calificacion del segundo corte:" +
                                  " " + segundoCorte + " " + "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

            if (tercerCorte != 0 && tercerCorte < 3)
            {
                Console.WriteLine("Tu calificacion del tercer corte:" +
                                  " " + segundoCorte + " " + "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

            if (cuartoCorte != 0 && cuartoCorte < 3)
            {
                Console.WriteLine("Tu calificacion del cuarto corte:" +
                                  " " + cuartoCorte + " " + "es inferior, a la calificiacion necesaria para aprobar el curso");
            }

        }
        else
        {
            Console.WriteLine("Tus calificaciones cumplen para aprobar el curso");
        }

        Console.WriteLine(promedioanual);

    break;

    /// <summary>
    /// Variables para capturar e imprimir el horario semanal estudiantil
    /// </summary>
    /// <returns>listas del detalle de variables para el calculo del horario estudiantil</returns>
    
    case "3":

        var horasDiariasAprox = 0;
        var horasDiariasAsignatura = 0;
        var numeroDias = 0;
        var numeroDiasAsignatura = 0;
        var horarioSemanalCursado = "";
        var horarioMensualCursado = "";
        var horarioSemanalAsignatura = "";
        var horarioMensualAsignatura = "";
        const int ValorMultiplicacionDias = 30;

        Console.WriteLine("Numero de horas semanales y mensuales:");
        Console.WriteLine("Ingresa el numero de horas cursadas en el dia, se sumara una hora de transporte al valor ingresado:");
        horasDiariasAprox = Convert.ToInt32(Console.ReadLine());
        horasDiariasAprox++;
        Console.WriteLine("Ingresa el numero de dias cursados en la semana:");
        numeroDias = Convert.ToInt32(Console.ReadLine());
        horarioSemanalCursado = ("Tu horario semanal es:" + " " + (horasDiariasAprox * numeroDias));
        horarioMensualCursado = ("Tu horario mensual es:" + " " + (horasDiariasAprox * ValorMultiplicacionDias));

        if (horasDiariasAprox > 10 && numeroDias > 5)
        {
            Console.WriteLine("Tu horario cursado, supera el numero de horas recomendadas por los profesionales de la Salud");
        }

        Console.WriteLine(horarioSemanalCursado);
        Console.WriteLine(horarioMensualCursado);
     break;

    /// <summary>
    /// Capturar y ver detalle de las horas semanalas y mensuales necesarias para cursar una materia
    /// </summary>
    /// <returns>listas del detalle de la solicitud del calculo del promedio del horario estudiantil</returns>
    
    case "4":
        Console.WriteLine("Numero de horas semanales y mensuales neecesarias para cursar una materia:");
        Console.WriteLine("Ingresa el numero de horas diarias de la asignatura, se sumara una hora de transporte al valor ingresado:");
        horasDiariasAsignatura = Convert.ToInt32(Console.ReadLine());
        horasDiariasAsignatura++;
        Console.WriteLine("Ingresa el numero de dias cursados en la semana:");
        numeroDiasAsignatura = Convert.ToInt32(Console.ReadLine());
        horarioSemanalAsignatura = ("El horario semanal para cursar esta asignatura es:" + " " + (horasDiariasAsignatura) * (numeroDiasAsignatura));
        horarioMensualAsignatura = ("El horario mensual para cursar esta asignatura es:" + " " + (horasDiariasAsignatura) * (numeroDiasAsignatura) * (ValorMultiplicacionDias));

        Console.WriteLine(horarioSemanalAsignatura);
        Console.WriteLine(horarioMensualAsignatura);

    break;

    default: Console.WriteLine("El valor ingresado no corresponde a las opciones disponibles !Gracias por tilizar este tu campus virtual¡");

    break;
}