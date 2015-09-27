using System.Collections.Generic;

namespace CarrosAngulares.Carro
{
    public interface ICarroRepository
    {
        List<Carro> listarDestaques();
        List<Marca> listarMarcas();
        bool adicionarCarro(Carro car);
        List<Carro> listarFiltro(Filtro filtro);
    }
}