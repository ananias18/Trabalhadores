

public class Aluno:Pessoa
{
    private int mat;
    private string curso;

    public void cancelarMatr()
    {
        Console.WriteLine("Matrícula será cancelada");
    }

    public int getMat()
    {
        return mat;
    }
    public string getCurso()
    {
        return curso;
    }
    public void setMat(int m)
    {
        this.mat = m;
    }
    public void setCurso(string c)
    {
        this.curso = c;
    }
}