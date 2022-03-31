

public class program
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Aluno p2 = new Aluno();
        Professor p3 = new Professor();
        Funcionario p4 = new Funcionario();

        p1.setName("Pedro");
        p2.setName("Maria");
        p3.setName("Claudio");
        p4.setName("Fabiana");

        p1.setSexo("Masculino");
        p4.setSexo("Feminino");
        p2.setIdade(18);

        p2.setCurso("Informatica");
        p3.setSalario(2500.75f);
        p4.setSetor("Estoque");


        Console.WriteLine(p1.toString());
        Console.WriteLine(p2.toString());
        Console.WriteLine(p3.toString());
        Console.WriteLine(p4.toString());
    }
}
