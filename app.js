(function(){
	var app = angular.module('carrosAngulares', []);

	app.controller('BuscaController', function(){
		this.mostrarBusca = true;

		this.clickBusca = function() {
			this.mostrarBusca = !this.mostrarBusca;
		}
	});
})();