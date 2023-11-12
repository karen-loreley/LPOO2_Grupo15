using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Ticket
    {
        private int TicketNro;

        public int ticketnro
        {
            get { return TicketNro; }
            set { TicketNro = value; }
        }
        private DateTime FechaHoraEnt;

        public DateTime fechahoraent
        {
            get { return FechaHoraEnt; }
            set { FechaHoraEnt = value; }
        }
        private DateTime FechaHoraSal;

        public DateTime fechahorasal
        {
            get { return FechaHoraSal; }
            set { FechaHoraSal = value; }
        }
        private int ClienteDNI;

        public int clienteDNI
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }
        private int TVCodigo;

        public int tvcodigo
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }
        private string Patente;

        public string patente
        {
            get { return Patente; }
            set { Patente = value; }
        }
        private int SectorCodigo;

        public int sectorcodigo
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }
        private double Duracion;

        public double duracion
        {
            get { return Duracion; }
            set { Duracion = value; }
        }
        private decimal Tarifa;

        public decimal tarifa
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }
        private decimal Total;

        public decimal total
        {
            get { return Total; }
            set { Total = value; }
        }
    }
}
