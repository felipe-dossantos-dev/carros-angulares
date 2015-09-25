using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Http;

namespace CarrosAngulares.Carro
{
    [ServiceContract]
    public interface ICarroService
    {
        [OperationContract]
        [WebInvoke(Method="GET", RequestFormat=WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json, UriTemplate="Carros/")]
        List<Carro> listarCarros();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Novo/", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool adicionarCarro([FromBody]Carro car); 
    }
}