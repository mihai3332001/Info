var OrasController = angular.module("OrasController", []);
OrasController.controller("ListController", ['$scope', '$http',
    function ($scope, $http) {
        $http.get('/api/orase').then(function (response, status, headers, config) {
            $scope.orase = response.data;
        }
        );
      
    }]);

OrasController.controller("ViewController", ['$scope', '$http', '$routeParams',
    function ($scope, $http, $routeParams) {
        $http.get('/api/orase').then(function (response) {
            $scope.orase = response.data;

        });
        if ($routeParams.id !== 0) {
            $scope.title = "Edit Oras";
            $http.get('/api/orase/' + $routeParams.id).then(function (response) {
                $scope.oras = response.data.oras;
                $scope.lat = response.data.lat;
                $scope.long = response.data.long;
                $scope.judetID = response.data.judetID;
            }); 
            }  
      
    }]);

OrasController.controller("TransportListController", ['$scope', '$rootScope', '$http', '$routeParams', 
    function ($scope, $rootScope, $http, $routeParams) {
        $http.get('/api/orase').then(function (response) {
          
        });
        if ($routeParams.id !== 0) {
            $scope.title = "Transport in comun";
            $http.get('/api/orase/' + $routeParams.id).then(function (response) {
                $scope.oras = response.data.oras;
                $scope.transports = response.data;
                $rootScope.items = response.data.id;
            });
        }
        else if ($scope.transports.id === 0) {
            $scope.orasID = response.data.id;
        }

    }]);

OrasController.controller("TransportEditController", ['$scope', '$http', '$routeParams', '$location',
    function ($scope, $http, $routeParams, $location) {
        $http.get('/api/transport').then(function (response) {
            $scope.transports = response.data;
           $scope.orasID = $scope.items;
        });
        if ($routeParams.id) {
            $http.get('/api/transport/' + $routeParams.id).then(function (response) {
                $scope.name = response.data.name;
                $scope.oras = response.data.ora.oras;
                $scope.orasID = response.data.orasID;             
            });
        }

        $scope.save = function () {
           
            var objTransport = {
                ID: $routeParams.id,
                Name: $scope.name,
                OrasID: $scope.orasID
            }
            if ($routeParams.id !== 0) {
                $http.put('/api/transport/' + $routeParams.id, objTransport).then(function (response) {
                    id = $scope.orasID;
                    $location.path('/transport/' + id);
                });
               
            }
            else {
                $http.post('/api/transport', objTransport).then(function (response) {
                    id = $scope.orasID;
                    $location.path('/transport/' + id);
                }).then(function (response) {
                    console.log($http.put);
                });          
            }
          }

    }]);


OrasController.controller("TransportDeleteController", ['$scope', '$http', '$rootScope', '$routeParams', '$location',
    function ($scope, $http, $rootScope, $routeParams, $location) {
        $http.get('api/transport/' + $routeParams.id).then(function (response) {
            $scope.Name = response.data.name;
            $scope.orasID = response.data.orasID;
        });
        $scope.delete = function () {
            if ($routeParams.id !== 0) {
                $http.delete('/api/transport/' + $routeParams.id).then(function (response) {
                    $location.path('/transport/' + $scope.orasID);
                });
            }
        };
    }]);

OrasController.controller("DeleteController", ['$scope', '$http', '$routeParams', '$location',
    function ($scope, $http, $routeParams, $location) {
        $http.get('api/orase/' + $routeParams.id).then(function (response) {
            $scope.oras = response.data.oras;
            $scope.lat = response.data.lat;
            $scope.long = response.data.long;
        });
        $scope.delete = function () {
            if ($routeParams.id !== 0) {
                $http.delete('/api/orase/' + $routeParams.id).then(function (response) {
                    $location.path('/list');
                });
            }
        };
    }]);

OrasController.controller("EditController", ['$scope', '$http', '$routeParams', '$location',
    function ($scope, $http, $routeParams, $location) {
        $http.get('/api/orase').then(function (response) {
            $scope.orase = response.data;
        });
    
        $scope.save = function () {
           
            var obj = {
                ID: $scope.id,
                Oras: $scope.oras,
                Lat: $scope.lat,
                Long: $scope.long,
                JudetID: $scope.judets.selectedOptions[0].judID
            };
            if ($scope.id === 0) {
             
                $http.post('/api/orase', obj).then(function (response) {
                    $location.path('/list');
                });
            }
            else {
                $http.put('/api/orase/' + $scope.id, obj).then(function (response) {
                    $location.path('/list');
                });
            }
        }
        $scope.id = 0;
        $scope.getJudet = function () {
            var judet = $scope.judetID;
            if (judet) {
                $http.get('/api/orase').then(function (response) {
                    var judSearch = response.data;
                    $scope.judets = {
                        model: null,
                        availableOptions:
                        judSearch.map(function (item) {
                            return {
                                jud: item.judet.judet1,
                                judID: item.judetID
                            }
                        })
                    };
                    var keys = $scope.judets.availableOptions;
                    var s = 0;
                    $scope.unique = {};
                    $scope.distinct = [];
                    for (var i in keys) {
                        if (typeof ($scope.unique[keys[i].jud]) === "undefined") {
                            $scope.distinct[s] = { "jud": keys[i].jud, "judID": keys[i].judID };
                            s++;
                        }
                        $scope.unique[keys[i].jud] = 0;
                    }
                    

                    $scope.judets.availableOptions = $scope.distinct;

                  

                   $scope.judets.selectedOptions =  keys.filter(function (item) {
                       if (item.judID === judet) {
                          return  item.jud;
                       }
                   });
                });
            } else {
                $http.get('/api/orase').then(function (response) {
                    var judSearch = response.data;
                    $scope.judets = {
                        model: null,
                        availableOptions:
                        judSearch.map(function (item) {
                            return {
                                jud: item.judet.judet1,
                                judID: item.judetID
                            }
                        })
                    };
                    var keys = $scope.judets.availableOptions;
                    var s = 0;
                    $scope.unique = {};
                    $scope.distinct = [];
                    for (var i in keys) {
                        if (typeof ($scope.unique[keys[i].jud]) === "undefined") {
                            $scope.distinct[s] = { "jud": keys[i].jud, "judID": keys[i].judID };
                            s++;
                        }
                        $scope.unique[keys[i].jud] = 0;
                    }
                    $scope.judets.availableOptions = $scope.distinct;
                });
            }
        }

        if ($routeParams.id) {
            $scope.id = $routeParams.id;
            $scope.title = "Edit Oras";
            $http.get('/api/orase/' + $routeParams.id).then(function (response) {
                $scope.oras = response.data.oras;
                $scope.lat = response.data.lat;
                $scope.long = response.data.long;
                $scope.judetID = response.data.judetID;
                $scope.getJudet();
            });
        }
        else {
            $http.get('/api/orase/').then(function (response) {
            $scope.judetID = response.data.judetID;
            $scope.getJudet();
            $scope.title = "Adauga Oras";
            });
        }
    }
]);

//EmpControllers.controller("ListController", ['$scope', '$http',
//    function ($scope, $http) {
//        $http.get('/api/employee').success(function (data) {
//            $scope.employees = data;
//        });
//    }
//]);  