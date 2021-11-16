﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlDeAduana
{
    public class PaquetePesado : Paquete, IAduana, IAfip
    {
        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }

        decimal IAfip.Impuestos
        {
            get
            {
                return (this.costoEnvio * 25) / 100;
            }
        }


        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) 
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + (this.Impuestos) + ((IAfip)this).Impuestos;
        }

        public override string ObtenerInformacionDePaquete()
        {
            return $"{base.ObtenerInformacionDePaquete()}\nNo tiene prioridad.";
        }

    }
}
