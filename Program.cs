using ExemplosExplorandoC.Models;
// MODIFICA A CONFIGURAÇÃO DA LOCALIZAÇÃO DO MEU CODIGO
using System.Globalization; 
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// MODIFICA A CONFIGURAÇÃO DA LOCALIZAÇÃO DO MEU CODIGO

// UTILIZANDO DICTIONARY - chave unica que nao dveve se repetir

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("BA","Bahia");
estados.Add("SP","São Paulo");
estados.Add("PE","Pernambuco");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("-_------__--__--_--__");
estados.Remove("BA");

estados["SP"] = "São Paulo - Alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";

if (estados.ContainsKey(chave)) {
    Console.WriteLine("EXITE NO DICTIONARY");
}else { 
    Console.WriteLine("NÂO EXISTE NO DICTIONARY");
}

// UTILIZANDO PILHA STACK - o ultimo a entrar é o primeiro a sair

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int linha in pilha)
// {
//     Console.WriteLine(linha);
// }

// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

// foreach (int linha in pilha)
// {
//     Console.WriteLine(linha);
// }




// UTILIZANDO FILA QUEUE - o primeiro a entrar é o primeiro a sair

// Queue<int> file = new Queue<int>();

// file.Enqueue(2);
// file.Enqueue(3);
// file.Enqueue(4);

// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo elemneto {file.Dequeue()}");

// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }




// UTILIZANDO TRY E CATCH E FINALLY
// try
// {
//         string[] leituras = File.ReadAllLines("Arquivos/arquivos_Leitura.txt");

//         foreach (string linha in leituras)
//         {
//             Console.WriteLine(linha);
//         }

// }catch (Exception e) {
//     Console.WriteLine("Erro ao tentar acessar o arquivo");
// }finally {
//     Console.WriteLine("Cheguei até aqui");
// }








/*
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

*/