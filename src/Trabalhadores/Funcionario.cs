

public class Funcionario : Pessoa
{
    private string setor;
    private bool trabalhando;

    public void mudaTrabalho()
    {

    }

    public string getsetor()
    {
        return this.setor;
    }
    public bool getTrabalhando()
    {
        return this.trabalhando;
    }
    public void setSetor(string s)
    {
        this.setor = s;
    }
    public void setTrabalhando(bool t)
    {
        this.trabalhando = t;
    }
}