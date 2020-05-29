namespace HerancaPoo
{
    // Herança da superclasse "Pessoa"
    public class CNPJ : Pessoa
    
    {
        public string cnpj;

        public bool validarCNPJ(){
            if(cnpj != null){
                return true;
            }

            return false;
        }
    }
}