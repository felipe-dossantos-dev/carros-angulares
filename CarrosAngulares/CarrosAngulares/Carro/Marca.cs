using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CarrosAngulares.Carro
{
    [DataContract]
    public class Marca
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public String descricao { get; set; }
    }
}