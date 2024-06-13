#region Documentación
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
const int ValorDivisionSemestre = 2;
const int ValorDivisionanual = 4;

/// <summary>
/// Capturar y ver detalle del promedio semestral
/// </summary>
/// <returns>listas del detalle de la solicitud del calculo del promedio semestral</returns>
Console.WriteLine("Tu promedio actual semestral:");
Console.WriteLine("Ingresa el valor de tu primer corte:");
primerCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu segundo corte:");
segundoCorte = Convert.ToDouble(Console.ReadLine());
promedioSemestral = ("Tu promedio del semestre es:" + " " + (primerCorte + segundoCorte) / (ValorDivisionSemestre));

Console.WriteLine(promedioSemestral);

/// <summary>
/// Capturar y ver detalle del promedio anual
/// </summary>
/// <returns>listas del detalle de la solicitud del calculo del promedio anual</returns>
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

Console.WriteLine(promedioanual);

/// <summary>
/// Variables para capturar e imprimir el horario semanal estudiantil
/// </summary>
/// <returns>listas del detalle de variables para el calculo del horario estudiantil</returns>
var horasDiariasAprox = 0;
var horasDiariasAsignatura = 0;
var numeroDias = 0;
var numeroDiasAsignatura = 0;
var horarioSemanalCursado = "";
var horarioMensualCursado = "";
var horarioSemanalAsignatura = "";
var horarioMensualAsignatura = "";
const int ValorMultiplicacionDias = 30;

/// <summary>
/// Capturar y ver detalle de las horas semanalas y mensuales necesarias para cursar una materia
/// </summary>
/// <returns>listas del detalle de la solicitud del calculo del promedio del horario estudiantil</returns>
Console.WriteLine("Numero de horas semanales y mensuales:");
Console.WriteLine("Ingresa el numero de horas cursadas en el dia:");
horasDiariasAprox = Convert.ToInt32(Console.ReadLine());
horasDiariasAprox++;
Console.WriteLine("Ingresa el numero de dias cursados en la semana:");
numeroDias = Convert.ToInt32(Console.ReadLine());
horarioSemanalCursado = ("Tu horario semanal es:" + " " + (horasDiariasAprox * numeroDias));
horarioMensualCursado = ("Tu horario mensual es:" + " " + (horasDiariasAprox * ValorMultiplicacionDias));

Console.WriteLine(horarioSemanalCursado);
Console.WriteLine(horarioMensualCursado);

/// <summary>
/// Capturar y ver detalle de las horas semanalas y mensuales necesarias para cursar una materia
/// </summary>
/// <returns>listas del detalle de la solicitud del calculo del promedio del horario estudiantil</returns>
Console.WriteLine("Numero de horas semanales y mensuales neecesarias para cursar una materia:");
Console.WriteLine("Ingresa el numero de horas diarias de la asignatura:");
horasDiariasAsignatura = Convert.ToInt32(Console.ReadLine());
horasDiariasAsignatura++;
Console.WriteLine("Ingresa el numero de dias cursados en la semana:");
numeroDiasAsignatura = Convert.ToInt32(Console.ReadLine());
horarioSemanalAsignatura = ("El horario semanal para cursar esta asignatura es:" + " " + (horasDiariasAsignatura) * (numeroDiasAsignatura));
horarioMensualAsignatura = ("El horario mensual para cursar esta asignatura es:" + " " + (horasDiariasAsignatura) * (numeroDiasAsignatura) *(ValorMultiplicacionDias));

Console.WriteLine(horarioSemanalAsignatura);
Console.WriteLine(horarioMensualAsignatura);