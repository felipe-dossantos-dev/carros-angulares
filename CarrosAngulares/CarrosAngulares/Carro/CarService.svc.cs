using System.Collections.Generic;

namespace CarrosAngulares.Carro
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CarService.svc or CarService.svc.cs at the Solution Explorer and start debugging.
    public class CarService : ICarroService
    {
        static ICarroRepository repo = new CarroRepository();

        public List<CarrosAngulares.Carro.Carro> listarCarros()
        {
            return repo.listarCarros();
        }

        public bool adicionarCarro(CarrosAngulares.Carro.Carro car)
        {
            return repo.adicionarCarro(car);
        }
    }
}
