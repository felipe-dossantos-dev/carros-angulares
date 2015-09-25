using System.Collections.Generic;

namespace CarrosAngulares.Carro
{
    public interface ICarroRepository
    {
        List<Carro> listarCarros();
        bool adicionarCarro(Carro car); 
    }
}