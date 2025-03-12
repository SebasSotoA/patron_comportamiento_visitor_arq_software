using P_patron_comportamiento_visitor.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Interfaces
{
    internal interface IVisitor
    {
        void VisitUsuario(Usuario usuario);
        void VisitPedido(Pedido pedido);
        void VisitProducto(Producto producto);
   
    }
}
