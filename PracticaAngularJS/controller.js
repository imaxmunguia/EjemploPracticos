var app = angular.module("MyFirstApp",[]);
app.controller("FirstController",["$scope",function(m){
	m.nombre="Isack M.";
	m.nuevoComentario={};
	m.comentarios = [
	{
		comentario: "Que bien",
		usuario: "IM"
	},
	{
		comentario: "Que mal tuto",
		usuario: "otro_user"
	}
	];
	m.agregarComentario = function(){
		m.comentarios.push(m.nuevoComentario);
		m.nuevoComentario={};
	}
}]);