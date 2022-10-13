using ExemplosExplorandoC.Models;
// MODIFICA A CONFIGURAÇÃO DA LOCALIZAÇÃO DO MEU CODIGO
using System.Globalization; 
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// MODIFICA A CONFIGURAÇÃO DA LOCALIZAÇÃO DO MEU CODIGO

Pessoa p1 = new Pessoa("Jaylan", "Esquivel");
p1.Idade  = 24;

Pessoa p2 = new Pessoa(nome: "Josemir", sobrenome: "Esquivel");
p2.Idade  = 27;

Curso cursoIngles = new Curso("Inglês");
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();

// CONVERTENDO VALORES MONETARIOS
Console.WriteLine("#####################");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // FORMATANDO CULTURA MSM COM CODIGO DEFINIDO


// CONVERTENDO VALORES PRCENTAGEM

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

// FORMATANDO VALOR PERSONALIZADO

int num = 121415;

Console.WriteLine(num.ToString("##-##-##"));

// FORMATANDO DATA E HORA

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/mm/yyyy HH:mm"));

Console.WriteLine(data.ToShortDateString()); // somete data
Console.WriteLine(data.ToShortTimeString()); // somete hora

string dataString = "12/04/2022 18:00";

DateTime data1 = DateTime.Parse(dataString);

DateTime.TryParseExact(dataString, "dd-mm-yyyy HH:mm", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data2);

Console.WriteLine(data2);