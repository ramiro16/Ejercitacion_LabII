using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlDeAduana
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return (this.costoEnvio * 35) / 100;
            }
        }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public virtual string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de Seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Peso en KG: {this.pesoKg}");

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            decimal retorno;

            retorno = this.costoEnvio + this.Impuestos;

            return retorno;
        }
    }
}
