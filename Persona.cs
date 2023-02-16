using System;

namespace Tarea2._2
{
    internal class Persona
    {
        protected String nombre;
        protected DateTime? fechaNacimiento;
        int edad;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                edad = (DateTime.Now.Year - fechaNacimiento.Value.Year);
                return edad;
            }

        }
        public Persona()
        {
            nombre = String.Empty;
            fechaNacimiento = null;
        }
        public Persona(String nombre, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return nombre.ToUpper() + " " + Edad;
        }
    }
}
