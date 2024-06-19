#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <IMatriculas>                                                                      
 * DescripciÓn   : <Interfas de la clase matriculas>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <19-06-2024>                                                                             
 *                                                                                                           
 * Fecha         Autores         	Modificación                                                                 
 * ===========   ============   	=====================
 ***************************************************************************************************/
#endregion Documentación
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVirtual.Interfaces
{
    internal interface IMatriculas
    {
        int Id { get; set; }
        int IdAsignaturamatriculada { get; set; }
        string TipoInscripcion { get; set; }
        string Nombre { get; set; }
        string Semestreinscripcion { get; set; }
    }
}
