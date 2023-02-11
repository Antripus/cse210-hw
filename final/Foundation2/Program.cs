using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encapsulation - Product ordering system");

        // Crear 2 pedidos con 3 productos c/u
        // llama a los metodos para obtener la etiqueta de
        // embalaje
        // envio
        // precio del pedido
        // y q muestre los resultados

        // Address direccion = new Address("calle", "ciudad", "provincia", "Pais");
        // Customer cliente1 = new Customer("Juan", direccion);
        // Order ord1 = new Order(cliente1);

        List<Order> ordenes = new List<Order> ();

        Random rnd = new Random();
        string[] calles = {"calle", "Rodriguez Pena 2232", "El alamo 4234", "Nostra Damus 99", "Seven Up 1232", "Corrientes 92", "Ruta 66"};
        string[] ciudades = {"ciudad", "El Talar", "CABA", "Villa Lugano", "Orem", "Provo", "Sprigfield"};
        string[] provincias = {"provincia", "Utah", "Bueno Aires", "Cordoba", "Mendoza", "Los Angeles", "California"};
        string[] paises = {"Pais", "Argentina", "USA", "United State", "Uruguay", "Italia", "Rusia", "Armenia"};
        string[] nombres = {"Jhon", "Debra", "Federico", "Al Capone", "Blake Smith", "Javito", "Keylucha", "Evangelina", "Brad"};
        string[] nombresProductos = {"Coke", "Cockies", "CellPhone", "Dress", "T-Shirt", "6 Glases", "Ibuprophen", "Brom", "Picture"};
        string[] codigos = {"ABB1001", "ABB1002", "ABB1003", "ABB1004", "ABB1005", "ABB1006", "ABB1007", "ABB1008", "ABB1009"};

        
        // for(int i = 0; i < 10; i++)
        // {
        //     float test = (float)((rnd.NextDouble()*100) - 1);

        //     string dosDecimal = test.ToString("0.##");
        //     Console.WriteLine(dosDecimal);
        // }
        

        int x = 0;
        int cantOrdenes = 3; // 3 ordenes
        while (cantOrdenes > 0){
            x = x+1;
            Address direccion = new Address(calles[rnd.Next(calles.Length)], ciudades[rnd.Next(ciudades.Length)], provincias[rnd.Next(provincias.Length)], paises[rnd.Next(paises.Length)]);
            Customer cliente = new Customer(nombres[rnd.Next(nombres.Length)], direccion);
            Order newOrden = new Order(cliente); //Creo la orden con los datos random
            
            int cantProductos = 3;
            while (cantProductos >0)
            {
                
                float randomPrice = (float)((rnd.NextDouble()*100) - 1);
                Product producto = new Product(nombresProductos[rnd.Next(nombresProductos.Length)],codigos[rnd.Next(codigos.Length)],randomPrice,rnd.Next(1,5));
                newOrden.addProduct(producto);
                cantProductos = cantProductos -1;
            }
            //Agrego la orden a mi lista de ordenes
            ordenes.Add (newOrden);
            cantOrdenes = cantOrdenes -1;
        }
        int pedido = 0;
        foreach (Order o in ordenes)
        {
            List<string> productosLabel = o.getPackingLabel();
            string envioLabel = o.getShippingLabel();
            float costoTotal = o.getTotalCost();
            pedido = pedido +1;
            Console.WriteLine();
            Console.WriteLine($"Order: {pedido}");

            Console.Write("Name & Address: ");
            Console.WriteLine(envioLabel);

            Console.WriteLine("Products:");
            foreach (string p in productosLabel)
            {
                Console.WriteLine(p);
            }
     
            Console.Write("Total Cost: ");
            Console.WriteLine(costoTotal.ToString("0.##"));
        }
    }
}