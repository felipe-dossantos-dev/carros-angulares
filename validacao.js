$(function(){
	$("#formBusca").validate({
		debug : true,
		rules:{
			precoDe : {
				number : true,
				max : 1000000000
			},
			precoAte : {
				number : true,
				max : 1000000000
			},
			anoDe : {
				digits : true,
				range : [1950, 2150]
			},
			anoAte : {
				digits : true,
				range :[1950, 2150]
			},
			palavraChave : {
				maxlength : 30
			}
		},
		messages:{
			precoDe : {
				number : "Somente números",
				max : "Valor inválido"
			},
			precoAte : {
				number : "Somente números",
				max : "Valor inválido"
			},
			anoDe : {
				digits : "Somente números",
				range : "Valor inválido"
			},
			anoAte : {
				digits : "Somente números",
				range : "Valor inválido"
			},
			palavraChave : {
				maxlength : "No máximo 30 chars"
			}
		}
	});
});