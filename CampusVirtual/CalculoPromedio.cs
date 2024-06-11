#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <CalculoPromedioController>                                                                      
 * DescripciÓn   : <Controlador para registrar y mostrar el promedio de calificaciones>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <17-08-2017>                                                                             
 *                                                                                                           
 * Fecha         Autores         	Modificación                                                                 
 * ===========   ============   	=====================
 * 11-06-2024   <Pedro Castro>        1 - Version Inicial  
 ***************************************************************************************************/
#endregion Documentación

double PrimerCorte;
double SegundoCorte;
double TercerCorte;
double CuartoCorte;
string Promedioanual;
string PromedioSemestral;

/// <summary>
/// Capturar y ver detalle del promedio semestral
/// </summary>
/// <returns>listas del detalle de la solicitud de servicios</returns>
Console.WriteLine("Tu promedio actual semestral:");
Console.WriteLine("Ingresa el valor de tu primer corte:");
PrimerCorte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el valor de tu segundo corte:");
SegundoCorte = Convert.ToDouble(Console.ReadLine());
PromedioSemestral = ("Tu promedio del semestre es:" + PrimerCorte + SegundoCorte / 2);

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
Promedioanual = ("Tu promedio anual es:" + PrimerCorte + SegundoCorte + TercerCorte + CuartoCorte / 4);

Console.WriteLine(Promedioanual);
