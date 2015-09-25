using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarrosService.Carro
{
    public class CarroRepository : ICarroRepository
    {
        private List<Carro> carros;
        private int cont;

        public CarroRepository()
        {
            carros = new List<Carro>();
            cont = 3;
            carros.Add(new Carro
            {
                Codigo = 1,
                Categoria = 1,
                Marca = 1,
                Tipo = 1,
                Modelo = "Test1",
                Ano = new DateTime(2015, 12, 25),
                Preco = new Decimal(31312.32),
                Proprietario = "kagdfa", 
                Cor = "Verde", 
                DataAquisicao = new DateTime(2014,01,01),
                Obs = "OBSSDFASDFasdf", 
                Placa = "Placa de video"
            });
            carros.Add(new Carro
            {
                Codigo = 2,
                Categoria = 2,
                Marca = 2,
                Tipo = 2,
                Modelo = "Test2",
                Ano = new DateTime(2015, 12, 25),
                Preco = new Decimal(31312.32),
                Proprietario = "kagdfa",
                Cor = "Verde",
                DataAquisicao = new DateTime(2014, 01, 01),
                Obs = "OBSSDFASDFasdf",
                Placa = "Placa de video"
            });
        }

        List<Carro> ICarroRepository.listarCarros()
        {
            return carros;
        }

        bool ICarroRepository.adicionarCarro(Carro car)
        {
            car.Codigo = cont;
            carros.Add(car);
            cont++;
            return true;
        }
    }
}