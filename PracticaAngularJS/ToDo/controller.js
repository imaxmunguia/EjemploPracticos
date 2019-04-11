angular.module("ToDoList",["LocalStorageModule"])
       /*.config(function(localStorageServiceProvider){
		    localStorageServiceProvider.setPrefix('ToDoList')
                                       .setStorageType('localStorage')
                                       .setNotify(true, true)
         })*/
       .controller("ToDoController",function($scope,localStorageService){
		        
		   if(localStorageService.get("angular-toDoList")){
			   $scope.to_do = localStorageService.get("angular-toDoList");
		   }
		   else{
			   $scope.to_do = []; 
		   }		   
		   /*
			{
			   description: 'hacer algo',
			   date: '20180526 14:00'
			}
		   */
		   $scope.$watchCollection("to_do",function(newValue,oldValue){
			   localStorageService.set("angular-toDoList",$scope.to_do);			   
		   });
		   $scope.addAct = function(){
			   $scope.to_do.push($scope.newAct);			   
			   $scope.newAct = {};
		   }
		   $scope.clean = function(){
			   $scope.to_do=[];
		   }
	   });