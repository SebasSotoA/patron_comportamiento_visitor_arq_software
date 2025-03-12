using P_patron_comportamiento_visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Clases
{
    internal class Producto : IVisitable
    {
        private int _id_producto;
        private string _nombre_prod;
        private float _precio;

        public int Id_producto { get => _id_producto; set => _id_producto = value; }
        public string Nombre_prod { get => _nombre_prod; set => _nombre_prod = value; }
        public float Precio { get => _precio; set => _precio = value; }

        public Producto(int id_producto, string nombre_prod, float precio)
        {
            _id_producto = id_producto;
            _nombre_prod = nombre_prod;
            _precio = precio;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitProducto(this);
        }
    }
}
