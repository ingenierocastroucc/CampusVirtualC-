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

class Matriculas
{
    public int IdAsignaturamatriculada;
    public string NombreAsignatura;
    public bool Nivelacion;
    public List<Asignaturas> IntencidadHoras;
    public string Profesor;

    public Matriculas() 
    {
        IntencidadHoras = new List<Asignaturas>();
        Nivelacion = true;
    }

    public void UsoIntencidadHoraria() 
    {
        foreach (var item in IntencidadHoras) 
        { 
            Console.WriteLine($"{NombreAsignatura} posee los siguientes horarios disponibles {item.Horario}");
        }
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