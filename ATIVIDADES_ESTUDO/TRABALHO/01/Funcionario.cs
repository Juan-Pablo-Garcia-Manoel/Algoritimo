class Funcionario{
    
    /*Código*/
    private int codigo;

    public int getCodigo(){return codigo;}
    
    public void setCodigo(int novoCodigo){
        codigo=novoCodigo;
    }

    /*Nome*/
    private string nome;
    
    public string getNome(){return nome;}
    
    public void setNome(string novoNome){
        nome = novoNome;
    }

    /*Ano de contratação*/
    private int anoDeContratacao;
    
    public int getAnoDeContratacao(){return anoDeContratacao;}

    public void setAnoDeContratacao(int novoAnoDeContratacao){
        anoDeContratacao = novoAnoDeContratacao;
    }

}

