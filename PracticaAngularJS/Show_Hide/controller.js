angular.module("MyApp",[])
       .controller("ControllerApp",["$scope","$http",function(s,h){
		   s.loading = true;
		   s.posts = [];
		   s.nuevoPost = {};
		   h.get("http://jsonplaceholder.typicode.com/posts")
		    .then(function(response){
				s.posts = response.data;
				s.loading = false;
				console.log(response.data);
		    },
		    function(err){
				s.loading = false;
				console.log(err);
		    });
		   /*s.addPost = function(){
			   h.post("http://jsonplaceholder.typicode.com/posts",{
				   title:  s.nuevoPost.title,
                   body:   s.nuevoPost.body,
                   userId: 1				   
			   })
               .then(function(r){
				    console.log(r.data)
					s.posts.push(r.data);
                    s.nuevoPost={};					
				}),
				(function(e){
					console.log(e);
				});			   
		   }*/
}]);