namespace Heran_aPOO
{
    public class CPF : pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(){
           
           if(cpf != ""){
               return true;
           }

           return false;
        }
    }
}