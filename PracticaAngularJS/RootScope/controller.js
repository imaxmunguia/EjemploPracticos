angular.module("MyApp",[])
       .run(function($rootScope){
		   $rootScope.nombre = "Isack";			
	   })
	   .controller("ControllerApp",["$scope",function(s){
		   s.nombre = "Maximiliano";
		   setTimeout(function(){
			   s.$apply(function(){
				   s.nombre = ":3";
				   
			   });
		   },2000);
       }])
	   .controller("ChildController",function(){
		   
	   });