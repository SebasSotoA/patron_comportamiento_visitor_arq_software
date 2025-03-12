using P_patron_comportamiento_visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Clases
{
    internal class Pedido : IVisitable
    {
        private int _id_pedido;
        private int _id_cliente;
        private DateTime _fecha_pedido;
        private List<Producto> _productos;
        public int Id_pedido { get => _id_pedido; set => _id_pedido = value; }
        public int Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public DateTime Fecha_pedido { get => _fecha_pedido; set => _fecha_pedido = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }

        public Pedido(int id_pedido, int id_cliente)
        {
            _id_pedido = id_pedido;
            _id_cliente = id_cliente;
            _fecha_pedido = DateTime.Now;
            _productos = new List<Producto>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPedido(this);  
        }
    }
}
