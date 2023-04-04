namespace banco;
class Classebanco
{
    public string agência;
    public string tipo;
    public int valor;
    public string conta;

    public void saque (){
        valor--;
    }
    public void deposito (){
        valor++;
    }
    public void transacao (){
        valor--;
    }
    public void consulta (){
        valor;
    }

}