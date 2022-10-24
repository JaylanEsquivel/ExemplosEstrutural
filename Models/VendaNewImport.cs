using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemplosExplorandoC.Models
{
    public class VendaNewImport
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }



    }
}