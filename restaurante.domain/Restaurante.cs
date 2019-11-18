namespace restaurante.domain
{
    public class Restaurante
    {
        public Restaurante( ){}
        public Restaurante(id myProperty, string nome, string endereco, string bairro, string cidade, string estado) 
        {
            this.MyProperty = myProperty;
                this.nome = nome;
                this.endereco = endereco;
                this.bairro = bairro;
                this.cidade = cidade;
                this.estado = estado;
               
        }
                public id MyProperty {get; set; }

        public string nome {get; set; }

        public string endereco {get; set; }

        public string bairro {get; set; }

        public string cidade {get; set; }

        public string estado {get; set; }
    }
}