using System;

namespace Proj.Domain.Entities { //usando o domain do restaurante, pois o consumo se refere a um restaurante
    public class Consumo : Entity {

        public Consumo() { }

        public Consumo (int idRestaurante, Restaurante restaurante, DateTime data, double valor) {
         
            this.idRestaurante = idRestaurante;
            this.restaurante = restaurante;
            this.data = data;
            this.valor = valor;
        }
        public int idRestaurante { get; set; } //identifica de qual restaurante a conta esta referenciando
        public Restaurante restaurante { get; set; }
        public DateTime data { get; set; }
        public double valor { get; set; }
    }
}