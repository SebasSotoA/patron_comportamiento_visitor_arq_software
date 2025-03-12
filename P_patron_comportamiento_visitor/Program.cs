using P_patron_comportamiento_visitor.Clases;
using P_patron_comportamiento_visitor.Interfaces;

// 1. Crear el visitante
IVisitor visitor = new JSONExportVisitor();

// 2. Crear un Usuario y agregarle algunos productos
Usuario usuario = new Usuario("Juan Pérez", "123456");
usuario.Productos.Add(new Producto(1, "Laptop", 999.99f));
usuario.Productos.Add(new Producto(2, "Mouse", 25.50f));

// 3. Crear un Pedido y agregarle productos
Pedido pedido = new Pedido(1001, 999);
pedido.Productos.Add(new Producto(3, "Teclado", 45.00f));
pedido.Productos.Add(new Producto(4, "Monitor", 150.00f));

// 4. Crear un Producto suelto
Producto producto = new Producto(5, "Impresora", 80.00f);

// 5. Usar el visitante para exportar a JSON
usuario.Accept(visitor);   // Exporta info de Usuario a JSON
pedido.Accept(visitor);    // Exporta info de Pedido a JSON
producto.Accept(visitor);  // Exporta info de Producto a JSON

Console.ReadLine();
