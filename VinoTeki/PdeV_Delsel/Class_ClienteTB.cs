using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdeV_Delsel
{
    class Class_ClienteTB
    {
        int IdCliente;
        string Nombre;
        string RFC;
        string Direccion;
        string Telefono;
        string Email;
        string Razonsocial;

        public Class_ClienteTB()
        {
            
        }

        public Class_ClienteTB(int idCliente, string nombre, string rFC, string direccion, string telefono, string email, string razonsocial)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            RFC = rFC;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Razonsocial = razonsocial;
        }

        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string RFC1 { get => RFC; set => RFC = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Razonsocial1 { get => Razonsocial; set => Razonsocial = value; }
    }
}
