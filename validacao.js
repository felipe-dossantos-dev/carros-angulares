$(function(){
	$("#formBusca").validate({
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
	$("#formCarro").validate({
		rules : {
			marca : "required",
			modelo : {
				required :true,
				maxlength : 50
			},
			ano : {
				required :true,
				digits : true,
				range : [1950, 2150]
			},
			preco : {
				required : true,
				number : true,
				max : 1000000000
			},
			proprietario : {
				required : true,
				maxlength : 50
			},
			placa : {
				required : true,
				maxlength : 8
			},
			cor : {
				required : true,
				maxlength : 20
			},
			dataAquisicao : {
				required : true,
				date : true
			}
		},
		messages : {
			marca : "Escolha uma marca",
			modelo : {
				required : "Modelo é requerido",
				maxlength : "Campo com no máximo 50 chars"
			},
			ano : {
				required : "Digite o ano do carro",
				digits : "Somente números",
				range : "Valor inválido"
			},
			preco : {
				required : "Preço é requirido",
				number : "Preço é numérico",
				max : "Preço maior que valor máximo permitido"
			},
			proprietario : {
				required : "Proprietário é requerido",
				maxlength : "Campo com no máximo 50 chars"
			},
			placa : {
				required : "Placa é requerido",
				maxlength : "Campo com no máximo 8 chars"
			},
			cor : {
				required : "Cor é requerido",
				maxlength : "Campo com no máximo 20 chars"
			},
			dataAquisicao : {
				required : "Data de Aquisição é requirido",
				date : "Entrada tem que ser uma data no formato dd/mm/aaaa"
			}
		}
	});
});