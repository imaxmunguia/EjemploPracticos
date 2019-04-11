angular.module("MyAppModule",[])
	   .controller("MyAppController",["$scope",function(s){
		   s.horaAutomatica = new Date();
		   s.horaManual = new Date();
		 //setTimeout
		   setInterval(function(){
			   s.$apply(function(){
				   s.horaAutomatica=new Date();  
			  });
		   },1000);
		   document.querySelector("#mi_boton").addEventListener("click",function(){
			   //s.horaManual=new Date(); //Forma incorrecta de actualizar
			   s.$apply(function(){
				   s.horaManual=new Date();				   
			   });
			   console.log(s.horaManual);
		   });
		   s.myFunc = function(){
			   s.horaManual=new Date();
		   };
	   }]);