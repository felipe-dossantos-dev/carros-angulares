using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarrosService.Carro
{
    public interface ICarroRepository
    {
        List<Carro> listarCarros();
        bool adicionarCarro(Carro car); 
    }
}