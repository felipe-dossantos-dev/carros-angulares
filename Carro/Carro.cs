using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarrosService.Carro
{
    [DataContract]
    public class Carro
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public int Categoria { get; set; }

        [DataMember]
        public int Marca { get; set; }

        [DataMember]
        public int Tipo { get; set; }

        [DataMember]
        public String Modelo { get; set; }

        [DataMember]
        public DateTime Ano { get; set; }

        [DataMember]
        public Decimal Preco { get; set; }

        [DataMember]
        public String Proprietario { get; set; }

        [DataMember]
        public String Placa { get; set; }

        [DataMember]
        public String Cor { get; set; }

        [DataMember]
        public String Obs { get; set; } //Observacoes

        [DataMember]
        public DateTime DataAquisicao { get; set; }
    }
}