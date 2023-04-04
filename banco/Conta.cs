namespace banco;

class Conta
{
     
     public int Numero{get; set;}
     private double Saldo{get; set;}
     public double Limite{get; set;}


     public void Depositar(double valor){
        this.Saldo += valor;
     }

     public double MostrarSaldo(){
        return this.Saldo + this.Limite;
     }

     public void AcertarLimite(double valor){
        this.Limite = valor;
     }
     
     public void Sacar(double valor){
       if (valor > this.Saldo + this.Limite){
          Console.WriteLine("Não é possivel");
       }else{
         this.Saldo -= valor;
       }
       
       //
     }

}
