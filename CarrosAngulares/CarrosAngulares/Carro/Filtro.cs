using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CarrosAngulares.Carro
{
    [DataContract]
    public class Filtro
    {
        [DataMember]
        public String tipo { get; set; }

        [DataMember]
        public String categoria { get; set; }

        [DataMember]
        public String marca { get; set; }

        [DataMember]
        public String palavraChave { get; set; }

        [DataMember]
        public String anoDe { get; set; }

        [DataMember]
        public String anoAte { get; set; }

        [DataMember]
        public String precoDe { get; set; }

        [DataMember]
        public String precoAte { get; set; }

    }
}