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

	app.controller('CarrosController', ['$scope', '$http', function($scope, $http){
    	var controller = this;
    	controller.carros = [];

    	$http.get('http://localhost:61268/Carro/CarService.svc/Carros/').success(function(data){
    	  controller.carros = data;
    	});

      $scope.$on('setCarros', function(event, args) {
        controller.carros = args[0];
      });
  	}]);

  app.controller('MarcasController', ['$http', function($http){
      var controller = this;
      controller.marcas = [];
      $http.get('http://localhost:61268/Carro/CarService.svc/Marcas/').success(function(data){
          controller.marcas = data;
      });
  }]);

	app.controller('NovoCarroController', ['$scope','$http', function($scope, $http){
      this.sendPost = function() {
    		var filtro = $scope.filtro;
        filtro.marca = $('#formCarro #marca').val();
    		console.log(filtro);
    		if ($('#formCarro').valid()) {
      		$http({
     					url: 'http://localhost:61268/Carro/CarService.svc/Novo/',
      				method: 'POST',
      				headers: { 'Content-Type': 'application/json' },
  				    data: {
                "filtro" : filtro
              }
  					}).then(function(data) {
              alert('Inserido com Sucesso');
            });
  				$scope.novoCarro = {};
    		};
    	};
  	}]);  	

  app.controller('FiltroController', ['$rootScope','$scope','$http', function($rootScope, $scope, $http){
      this.sendPost = function() {
        var filtro = $scope.filtro;
        filtro.marca = $('#formBusca #marca').val();
        console.log(filtro);
        $http({
            url: 'http://localhost:61268/Carro/CarService.svc/CarrosFiltro/',
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            data: {
              "filtro" : filtro
            }
          }).then(function(carros) {
            $rootScope.$broadcast('setCarros', carros);
          });
          $scope.novoCarro = {};
      };
  }]);    
})();