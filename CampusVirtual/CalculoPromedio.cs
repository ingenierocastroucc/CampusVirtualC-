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
 ***************************************************************************************************/
#endregion Documentación

var PrimerCorte = 0.0;
var SegundoCorte = 0.0;
var TercerCorte = 0.0;
var CuartoCorte = 0.0;
var Promedioanual = "";
var PromedioSemestral = "";
var ValorDivisionSemestre = 2;
var ValorDivisionanual = 4;

/// <summary>
/// Capturar y ver detalle del promedio semestral
/// </summary>
/// <returns>listas del detalle de la solicitud de servicios</returns>
Console.WriteLine("Tu promedio actual semestral:");
Console.WriteLine("Ingresa el valor de tu primer corte:");
PrimerCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu segundo corte:");
SegundoCorte = Convert.ToDouble(Console.ReadLine());
PromedioSemestral = ("Tu promedio del semestre es:" + " " + (PrimerCorte + SegundoCorte) / (ValorDivisionSemestre));

Console.WriteLine(PromedioSemestral);

/// <summary>
/// Capturar y ver detalle del promedio anual
/// </summary>
/// <returns>listas del detalle de la solicitud de servicios</returns>
Console.WriteLine("Tu promedio actual");
Console.WriteLine("Ingresa el valor de tu primer corte:");
PrimerCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu segundo corte:");
SegundoCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu tercer corte:");
TercerCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu cuarto corte:");
CuartoCorte = Convert.ToDouble(Console.ReadLine());
Promedioanual = ("Tu promedio anual es:" + " " + (PrimerCorte + SegundoCorte + TercerCorte + CuartoCorte) / (ValorDivisionanual));

Console.WriteLine(Promedioanual);
