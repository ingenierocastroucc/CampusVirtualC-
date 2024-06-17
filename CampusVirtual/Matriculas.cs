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
 ***************************************************************************************************/
#endregion Documentación

using System.Text;

class Matriculas
{
    public int IdAsignaturamatriculada;
    public string NombreAsignatura;
    public List<Asignaturas> IntencidadHoras;
    public string Profesor;

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

class Profesor
{
    public int IdProfesor;
    public string Nombre;
    public bool Nivelacion;
    public int IntencidadHoraria;
    public string Asignatura;
}

class Asignaturas
{
    public int IdAsignatura;
    public string Nombre;
    public bool Nivelacion;
    public IntencidadHoraria Horario;
    public string Asignatura;
}

enum IntencidadHoraria
{ 
    Cuatro,
    Dos,
    Tres
}