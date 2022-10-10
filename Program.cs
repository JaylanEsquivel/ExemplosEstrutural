using ExemplosExplorandoC.Models;

Pessoa p1 = new Pessoa("Jaylan", "Esquivel");
p1.Idade  = 24;

Pessoa p2 = new Pessoa(nome: "Josemir", sobrenome: "Esquivel");
p2.Idade  = 27;

Curso cursoIngles = new Curso("Inglês");
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();