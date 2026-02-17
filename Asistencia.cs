using System;

namespace SistemaAsistenciaApp
{
    public class Asistencia
    {
        private string cedulaEstudiante;
        private DateTime fecha;
        private string estado;

        public string CedulaEstudiante
        {
            get { return cedulaEstudiante; }
            set { cedulaEstudiante = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Asistencia(string cedulaEstudiante, DateTime fecha, string estado)
        {
            this.cedulaEstudiante = cedulaEstudiante;
            this.fecha = fecha;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"{CedulaEstudiante},{Fecha.ToShortDateString()},{Estado}";
        }
    }
}