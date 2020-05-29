namespace HerancaPoo
{
    // Herança da superclasse "pessoa"
    public class CPF : Pessoa
    
    {
        public string cpf;
        public string rg;

        public bool Validarcpf(){
            if(cpf != null){
                return true;
            }

            return false;
        }


    }
}