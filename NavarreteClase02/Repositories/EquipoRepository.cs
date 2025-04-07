using NavarreteClase02.Models;

namespace NavarreteClase02.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                /*datos*/
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            Equipo barcelona = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            equipos.Add(ldu);
            equipos.Add(barcelona);
            return equipos;
        }
    }
}
