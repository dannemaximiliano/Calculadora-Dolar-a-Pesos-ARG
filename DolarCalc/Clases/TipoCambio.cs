﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarCalc.Clases
{
    internal class TipoCambio
    {
        public string Moneda { get; set; }
        public string Casa { get; set; }
        public string Nombre { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime FechaActualizacion { get; set; }

    }
}
