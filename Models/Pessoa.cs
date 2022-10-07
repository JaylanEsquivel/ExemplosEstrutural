using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorandoC.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome {

            get => _nome.ToUpper(); //BODY EXPRESSIONS => USADO PARA METHODOS SIMPLES
            set {
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser Vazio.");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade {
            get => _idade;
            set {
                if (value < 0) {
                    throw new ArgumentException("A idade não pode ser menor que 0.");
                }

                _idade = value;
            }


        }


        public void Apresentar() {
            Console.WriteLine($"Meu nome é {NomeCompleto} , Tenho {Idade} anos");
        }
    }
}