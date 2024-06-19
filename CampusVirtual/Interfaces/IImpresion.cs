using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVirtual.Interfaces
{
    internal class IImpresion
    {
        public void Impresionmatriculas(IMatriculas iMatriculas)
        {
            Console.WriteLine($"Tipo de inscripçion: {iMatriculas.TipoInscripcion}\nSemestre de inscripcion { iMatriculas.Semestreinscripcion }");
        }
    }
}
