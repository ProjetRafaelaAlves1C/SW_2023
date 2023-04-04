namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Etec MCM");
        Conta c = new Conta();
        //c.Saldo = 1500;
        c.Depositar(1500);
        c.AcertarLimite(500);
        c.Sacar(200);
        //Console.WriteLine("Saldo " + c.Saldo + " Seu limite é de: " +c.Limite);
        Console.WriteLine("Saldo " + c.MostrarSaldo());
    }
}
