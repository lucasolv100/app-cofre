using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofre
{
    public class Cofre
    {
        public Cofre()
        {
            Moedas = new List<Moeda>();
        }
        private List<Moeda> Moedas { get; set; }

        public void InserirMoedas(Moeda moeda)
        {
            Moedas.Add(moeda);
        }
        public double ValorTotalReais()
        {
            return Moedas.Sum(s => s.GetValor());
        }

        public int QuantidadeMoedas()
        {
            return Moedas.Count;
        }
        public int QuantidadeMoedasUmReal()
        {
            return Moedas.Count(c => c.GetValorExtenso() == NomeMoedaEnum.UmReal);
        }
        public double ValotTotalDolar()
        {
            return Moedas.Sum(c => c.GetValor() * 3.88);
        }

    }
}
