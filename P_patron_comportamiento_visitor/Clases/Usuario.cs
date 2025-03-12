using P_patron_comportamiento_visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Clases
{
    internal class Usuario : IVisitable
    {
        private string _nombre;
        private string _cedula;
        private List<Producto> _productos; 
        public string Nombre { get => _nombre; set => _nombre = value;}
        public string Cedula { get => _cedula;set => _cedula = value;}
        public List<Producto> Productos { get => _productos; set => _productos = value;}    

        public Usuario(string nombre, string cedula)
        {   
            _nombre = nombre;
            _cedula = cedula;
            _productos = new List<Producto>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitUsuario(this);
        }
    }
}
