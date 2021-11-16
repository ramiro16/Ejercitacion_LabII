using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlDeAduana
{
    public class GestionImpuestos
    {
        List<IAduana> impuestosAduana;
        List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }

        }

        public void RegistrarImpuestos(Paquete paquete)
        {

                impuestosAduana.Add(paquete);
                
                if (paquete is IAfip)
                {
                    IAfip paqueteAfip = (IAfip)paquete;
                    impuestosAfip.Add(paqueteAfip);
                }

        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal acum = 0;

            foreach (Paquete item in impuestosAfip)
            {
                acum += item.Impuestos;
            }

            return acum;
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal acum = 0;

            foreach (Paquete item in impuestosAduana)
            {
                acum += item.Impuestos;
            }

            return acum;
        }
    }
}
