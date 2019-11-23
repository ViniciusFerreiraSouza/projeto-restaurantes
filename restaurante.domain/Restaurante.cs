namespace restaurante.domain
{
    public class Restaurante
    {
        public Restaurante( ){}
        public Restaurante(int id, string nome, string endereco, string bairro, string cidade, string estado) 
        {
            this.id = id;
                this.nome = nome;
                this.endereco = endereco;
                this.bairro = bairro;
                this.cidade = cidade;
                this.estado = estado;
               
        }
        public int id {get; set; }

        public string nome {get; set; }

        public string endereco {get; set; }

        public string bairro {get; set; }

        public string cidade {get; set; }

        public string estado {get; set; }
    }
}