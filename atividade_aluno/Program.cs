namespace atividade_aluno;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();

        Console.WriteLine("Nome do aluno: ");
        aluno1.nome = Console.ReadLine();

        Console.WriteLine("Informe a primeira nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
        
        aluno1.resultado();


    }
}
