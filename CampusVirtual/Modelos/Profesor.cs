#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <Asignaturas>                                                                      
 * DescripciÓn   : <Clase las propiedades de los profesores>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <17-06-2024>                                                                             
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

namespace CampusVirtual.Models
{
    public class Profesor : Matriculas
    {
        public int IdProfesor;
        public string Nombre;
        public bool Nivelacion;
        public int IntencidadHoraria;
        public string Asignatura;
    }
}