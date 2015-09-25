(function(){
	var app = angular.module('carrosAngulares', []);

	app.config(function($httpProvider) {
      //Enable cross domain calls
      $httpProvider.defaults.useXDomain = true;

      //Remove the header used to identify ajax call  that would prevent CORS from working
      delete $httpProvider.defaults.headers.common['X-Requested-With'];
  });

	app.controller('GeralController', function(){
		this.mostrarBusca = false;
		this.mostrarCadastro = false;

		this.clickBusca = function() {
			this.mostrarBusca = !this.mostrarBusca;
		}

		this.clickCadastro = function() {
			this.mostrarCadastro = !this.mostrarCadastro;
		}
	});

	app.controller('CarrosController', ['$http', function($http){
    	var controller = this;
    	controller.carros = [];
    	$http.get('http://localhost:61268/Carro/CarService.svc/Carros/').success(function(data){
    	    controller.carros = data;
    	});
  	}]);

	app.controller('NovoCarroController', ['$scope','$http', function($scope, $http){
      this.sendPost = function() {
    		var car = $scope.novoCarro;
        car.codigo = 0;
        car.obs = "adfsfsfsfsfsfsfsfsfsfsfsfsfsfs";
    		console.log(car);
    		if ($('#formCarro').valid()) {
      		$http({
     					url: 'http://localhost:61268/Carro/CarService.svc/Novo/',
      				method: 'POST',
      				headers: { 'Content-Type': 'application/json' },
  				    data: {
                "car" : car
              }
  					}).then(function(data) {
              alert('Inserido com sucesso');
            });
  				$scope.novoCarro = {};
    		};
    	};
  	}]);  	

})();

function formatarData(data) {
  data = data.replace('/', '');
  return data;
}