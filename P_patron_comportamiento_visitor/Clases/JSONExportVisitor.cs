using P_patron_comportamiento_visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Clases
{
    internal class JSONExportVisitor:IVisitor
    {
        public void VisitUsuario(Usuario usuario)
        {
            var json = JsonSerializer.Serialize(new
            {
                usuario.Nombre,
                usuario.Cedula,
                Productos = usuario.Productos.Select(p => new
                {
                    p.Id_producto,
                    p.Nombre_prod,
                    p.Precio
                })
            });
            Console.WriteLine($"Exportando Usuario a JSON:\n{json}\n");
        }
        public void VisitPedido(Pedido pedido)
        {
            var json = JsonSerializer.Serialize(new
            {
                pedido.Id_pedido,
                pedido.Id_cliente,
                FechaPedido = pedido.Fecha_pedido.ToString("dd/MM/yyyy"),
                Productos = pedido.Productos.Select(p => new
                {
                    p.Id_producto,
                    p.Nombre_prod,
                    p.Precio
                })
            });
            Console.WriteLine($"Exportando Pedido a JSON:\n{json}\n");
        }
        public void VisitProducto(Producto producto)
        {
            var json = JsonSerializer.Serialize(new
            {
                producto.Id_producto,
                producto.Nombre_prod,
                producto.Precio
            });
            Console.WriteLine($"Exportando Producto a JSON:\n{json}\n");
        }

    }
}
