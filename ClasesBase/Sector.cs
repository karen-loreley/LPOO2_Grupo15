using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sector
    {
        private int SectorCodigo;

        public int sectorcodigo
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }
        private string Descripcion;

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private bool Habilitado;

        public bool habilitado
        {
            get { return Habilitado; }
            set { Habilitado = value; }
        }
        private string Identificador;

        public string identificador
        {
            get { return Identificador; }
            set { Identificador = value; }
        }
    }
}
