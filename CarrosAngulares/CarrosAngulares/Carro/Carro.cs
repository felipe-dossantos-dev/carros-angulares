using System;
using System.Runtime.Serialization;

namespace CarrosAngulares.Carro
{
    [DataContract]
    public class Carro
    {
        [DataMember]
        public String codigo { get; set; }

        [DataMember]
        public String categoria { get; set; }

        [DataMember]
        public String marca { get; set; }

        [DataMember]
        public String tipo { get; set; }

        [DataMember]
        public String modelo { get; set; }

        [DataMember]
        public String ano { get; set; }

        [DataMember]
        public String preco { get; set; }

        [DataMember]
        public String proprietario { get; set; }

        [DataMember]
        public String placa { get; set; }

        [DataMember]
        public String cor { get; set; }

        [DataMember]
        public String obs { get; set; } //Observacoes

        [DataMember]
        public String dataAquisicao { get; set; }
    }
}