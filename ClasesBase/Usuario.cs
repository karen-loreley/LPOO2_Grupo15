using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase 
{
    public class Usuario : IDataErrorInfo
    {
        private string UserName;

        public string username
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Rol;

        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
