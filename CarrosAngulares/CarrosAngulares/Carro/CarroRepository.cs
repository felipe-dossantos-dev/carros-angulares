using System;
using System.Collections.Generic;

namespace CarrosAngulares.Carro
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
                codigo = "1",
                categoria = "1",
                marca = "1",
                tipo = "1",
                modelo = "Test1",
                ano = "2015",
                preco = "31312.32",
                proprietario = "kagdfa", 
                cor = "Verde", 
                dataAquisicao = "01/01/2015",
                obs = "OBSSDFASDFasdf", 
                placa = "Placa de video"
            });
            carros.Add(new Carro
            {
                codigo = "2",
                categoria = "2",
                marca = "2",
                tipo = "2",
                modelo = "Test2",
                ano = "2015",
                preco = "31312.32",
                proprietario = "kagdfa",
                cor = "Verde",
                dataAquisicao = "01/01/2015",
                obs = "OBSSDFASDFasdf",
                placa = "Placa de video"
            });
        }

        List<Carro> ICarroRepository.listarCarros()
        {
            return carros;
        }

        bool ICarroRepository.adicionarCarro(Carro car)
        {
            car.codigo = cont.ToString();
            carros.Add(car);
            cont++;
            return true;
        }
    }
}