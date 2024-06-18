#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <Asignaturas>                                                                      
 * DescripciÓn   : <Clase las propiedades de las asignaturas>                                                      
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
    public class Asignaturas
    {
        public int IdAsignatura;
        public string Nombre;
        public bool Nivelacion;
        public IntencidadHoraria Horario;
    }

    public enum IntencidadHoraria
    {
        Cuatro,
        Dos,
        Tres
    }
}

