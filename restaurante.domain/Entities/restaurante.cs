using System.Collections.Generic;

namespace Proj.Domain.Entities {
    public class Restaurante: Entity {
        //Não esquecer de criar um construtor vazio para o EFF
        public Restaurante(){}
        public Restaurante(int id, string nome, string endereco, int numero, string cidade, string estado, List<Consumo> consumo) 
        {
                this.id = id; // o id vai ficar referenciado dentro de Entity
                this.nome = nome;
                this.endereco = endereco;
                this.numero = numero;
                this.cidade = cidade;
                this.estado = estado;
                this.consumo = consumo;      
        }
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public ICollection<Consumo> consumo { get; set; } //restaurante recebendo um list de consumos do restaurante
    }
}