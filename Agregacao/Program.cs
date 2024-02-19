// Agregação é um relacionamento do tipo: "tem um"

Professor prof1 = new Professor("Diego", "Matematica");
Professor prof2 = new Professor("Geovane", "Ingles");
Professor prof3 = new Professor("Giuliano", "Quimics");
Professor prof4 = new Professor("Guilherme", "Fisica");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);   
dep1.IncluirProfessor(prof4);   
dep1.ListaProfessores();

Departamento dep2 = new Departamento($"Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessores();



Console.ReadKey();
class Departamento
{


    public string? Nome { get; set; }
    public List<Professor>? professores { get; set; }

    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }
    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor); 
    }

    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome} \n");
            foreach (var prof in professores)
            Console.WriteLine($"{prof.Nome}" + "->"  + $"{prof.Disciplina}");
        
    }

}

class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }
    public Professor(string? nome, string? disciplina)
    {
            Nome = nome;
            Disciplina = disciplina;
    }
}