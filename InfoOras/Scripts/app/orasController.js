var OrasController = angular.module("OrasController", []);
OrasController.controller("ListController", ['$scope', '$http',
    function ($scope, $http) {
        $http.get('/api/orase').then(function (response, status, headers, config) {
            $scope.orase = response.data;
        }
        );
      
    }]);
OrasController.controller("EditController", ['$scope', '$http', '$routeParams',
    function ($scope, $http, $routeParams) {
        $http.get('/api/orase').then(function (response) {
            $scope.orase = response.data;
        });
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

                   $scope.judets.availableOptions = keys.filter(function (value, index) { return keys.indexOf(value) == index });
                   $scope.judets.selectedOptions =  keys.filter(function (item) {
                       if (item.judID == judet) {
                          return  item.jud;
                       }
                   });
                });
            } else {
                $scope.judet = null;
            }
        }
        $scope.save = function () {
            var obj = {
                ID: $scope.id,
                Oras: $scope.oras,
                Lat: $scope.lat,
                Long: $scope.long,
                JudetID: $scope.judet
            };
            if ($scope.id === 0) {
                $http.post('/api/orase', obj).then(function (response) {
                    $locationProvider.path('/list');
                })
            }
            else {
                $http.put('/api/orase', obj).then(function (response) {
                    $locationProvider.path('/list');
                })
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
            $scope.title = "Adauga Oras";
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