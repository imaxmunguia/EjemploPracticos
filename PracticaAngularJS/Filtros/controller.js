angular.module("MainModule",[])
       .filter("removeHtml",function(){
		   return function(texto){
			   return String(texto).replace(/<[^>]+>/gm,'');
		   }
	   })
	   .controller("FiltersController", function($scope){
		   $scope.mi_html = "<p>Hola mundo</p>"
		   $scope.mi_json = {
			   Id:       "0512198700554",
			   FirsName: "Isack",
			   LastName: "Munguia",
			   Age:      31,
               salary:   1100			   
		   }
	   });