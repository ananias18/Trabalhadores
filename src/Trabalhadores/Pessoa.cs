

public class Pessoa
{
    private string name;
    private int idade;
    private string sexo;

    public void fazerAniversario()
    {
        this.idade++;
    }

    public string getName()
    {
        return this.name;
    }
    public int getIdade()
    {
        return this.idade;
    }
    public string getSexo()
    {
        return this.sexo;
    }
    public void setName(string n)
    {
        this.name = n;
    }
    public void setIdade(int i)
    {
        this.idade = i;
    }
    public void setSexo(string s)
    {
        this.sexo = s;
    }

    public String toString()
    {
        return "Nome: " + this.name + "\nIdade: " + this.idade + "\nSexo: " + this.sexo;
    }
}