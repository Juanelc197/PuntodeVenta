using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdeV_Delsel
{
    class Class_ProductoTB
    {
        int IdProducto;
        string Producto;
        string Tipo;
        string Marca;
        string Modelo;
        string Descripcion;
        int Cantidad;
        int Costo;
        int Precio;

        public Class_ProductoTB()
        {

        }

        public Class_ProductoTB(int idProducto, string producto, string tipo, string marca, string modelo, string descripcion, int cantidad, int costo, int precio)
        {
            IdProducto = idProducto;
            Producto = producto;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Costo = costo;
            Precio = precio;
        }


        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public string Producto1 { get => Producto; set => Producto = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public int Costo1 { get => Costo; set => Costo = value; }
        public int Precio1 { get => Precio; set => Precio = value; }
    }
}
