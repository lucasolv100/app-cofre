using System;
using System.Collections.Generic;
using System.Text;

namespace Cofre
{
    public class Moeda
    {
        public Moeda()
        {
            Valor = 0;
        }
        private double Valor { get; set; }

        public bool SetValor(double valor)
        {
            switch (valor)
            {
                case 1:
                    Valor = 1;
                    return true;
                case 0.5:
                    Valor = 0.5;
                    return true;
                case 0.25:
                    Valor = 0.25;
                    return true;
                case 0.1:
                    Valor = 0.1;
                    return true;
                case 0.01:
                    Valor = 0.01;
                    return true;
                default:
                    return false;
            }
        }

        public double GetValor()
        {
            return Valor;
        }
        public string GetValorExtenso()
        {
            switch (Valor)
            {
                case 1:
                    return NomeMoedaEnum.UmReal;
                case 0.5:
                    return NomeMoedaEnum.CinquentaCentavos;
                case 0.25:
                    return NomeMoedaEnum.VinteCincoCentavos ;
                case 0.1:
                    return NomeMoedaEnum.DezCentavos;
                case 0.01:
                    return NomeMoedaEnum.UmCentavo;
                default:
                    return NomeMoedaEnum.ValorInvalido;
            }
        }
    }
}
