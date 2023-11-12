using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Cliente : IDataErrorInfo
    {
        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Telefono;

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        private int ClienteDNI;

        public int clienteDNI
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }





        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { string msg_error = null;
            switch (columnName) { 
                case "nombre":
                    msg_error = validar_nombre();
                    break;
                case "apellido":
                    msg_error = validar_apellido();
                    break;
                case "dni":
                    msg_error = validar_dni();
                    break;
                case "telefono":
                    msg_error = validar_telefono();
                    break;
            }
            return msg_error;
            }
        }

        private string validar_nombre() {
            if (String.IsNullOrEmpty(nombre))
            {
                return "el valor del campo es obligatorio";
            }
            return null;
        }

        private string validar_apellido()
        {
            if (String.IsNullOrEmpty(apellido))
            {
                return "el valor del campo es obligatorio";
            }
            return null;
        }

        private string validar_dni()
        {
            if (clienteDNI <=0)//cli_DNI <= 0
            {
                return "el valor del campo es obligatorio";
            }
            return null;
        }

        private string validar_telefono()
        {
            if (String.IsNullOrEmpty(telefono))
            {
                return "el valor del campo es obligatorio";
            }
            return null;
        }
    }
}
