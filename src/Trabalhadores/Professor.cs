

public class Professor : Pessoa
{
    private string especialidade;
    private float salario;

    public void receberAumento(float aum)
    {
        this.salario += aum;
    }

    public string getEspecialidade()
    {
        return this.especialidade;
    }
    public float getSalario()
    {
        return this.salario;
    }
    public void setEspecialidade(string e)
    {
        this.especialidade = e;
    }
    public void setSalario(float s)
    {
        this.salario = s;
    }
}