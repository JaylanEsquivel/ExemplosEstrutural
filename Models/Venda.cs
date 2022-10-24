using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorandoC.Models
{
    public class Venda
    {

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda{ get; set; }

        public Venda(int id,string produto, decimal valor, DateTime data) {

            Id = id;
            Produto = produto;
            Valor = valor;
            DataVenda = data;

        }


    }
}