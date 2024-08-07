﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Pago
    {
        private int id;
        private DateTime fecha;
        private Multa multa;
        private double monto;
        private PagoDatos pagoDb;

        public Pago(int id, DateTime fecha, Multa incidente, double monto)
        {
            pagoDb = new PagoDatos();

            this.id = id;
            this.fecha = fecha;
            this.multa = incidente;
            this.monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Multa Multa { get => multa; set => multa = value; }
        public double Monto { get => monto; set => monto = value; }

        public int agregarDb(DateTime fecha, int idIncidente, double monto)
        {
            return pagoDb.agregar(fecha, idIncidente, monto);
        }
    }
}
