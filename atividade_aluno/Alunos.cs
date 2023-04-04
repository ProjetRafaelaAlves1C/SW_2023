namespace atividade_aluno;
class Alunos
{
   public string nome="";
   public double nota1, nota2; 


   public double paraMedia(){
       double media = (nota1+nota2)/2;
       return media;
   }

   public string paraSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="aprovado";
        }else{
            situacao="reprovado";
        }
        return situacao;
   }

   public void resultado(){
      double resulMedia = paraMedia();
      string resulSituacao = paraSituacao(resulMedia);
      Console.Write(nome+" está "+resulSituacao+" com média: "+resulMedia);
   }
}