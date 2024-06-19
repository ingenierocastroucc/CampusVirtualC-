#region Documentación
/****************************************************************************************************
 * Propiedad intelectual Pedro castro                                                           
 ****************************************************************************************************
 * Unidad        : <Matriculas>                                                                      
 * DescripciÓn   : <Clase para establecer las clases de las matriculas>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <14-06-2024>                                                                             
 *                                                                                                           
 * Fecha         Autores         	Modificación                                                                 
 * ===========   ============   	=====================
 * 15-06-2024   <Pedro Castro>        1- Se crean las clases Matriculas, Profesor y Asiganturas.
 * 17-06-2024   <Pedro Castro>        2- Se crea  la  clase  Record y se elimina propiedad innecesaria.
 ***************************************************************************************************/
#endregion Documentación

using CampusVirtual.Interfaces;
using CampusVirtual.Models;
using System.Text;

namespace CampusVirtual.Models
{
    public class Matriculas : Asignaturas, IMatriculas
    {
        public int Id { get; set; }
        public int IdAsignaturamatriculada { get; set; }
        public string NombreAsignatura { get; set; }
        public List<Asignaturas> IntencidadHoras { get; set; }
        public string Profesor { get; set; }
        public string TipoInscripcion { get; set; }
        public string Semestreinscripcion { get; set; }

        public Matriculas()
        {
            IntencidadHoras = new List<Asignaturas>();
        }

        public string UsoIntencidadHoraria()
        {
            StringBuilder sbIntencidadHoraria = new StringBuilder();
            foreach (var item in IntencidadHoras)
            {
                sbIntencidadHoraria.AppendLine($"{NombreAsignatura} posee los siguientes horarios disponibles {item.Horario}");
            }

            return sbIntencidadHoraria.ToString();
        }
    }
}

public record AsignaturasNivelacion (int IdAsignatura, string Nombre, bool Nivelacion);