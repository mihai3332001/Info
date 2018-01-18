var OrasApp = angular.module('OrasApp', ['ngRoute', 'OrasController']);
OrasApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.when('/list',
        {
            templateUrl: 'Orase/list.html',
            controller: 'ListController'

        }).
        when('/create',
        {
            templateUrl: 'Orase/edit.html',
            controller: 'EditController'
        }).
        when('/edit/:id',
        {
            templateUrl: 'Orase/edit.html',
            controller: 'EditController'
        }).  
        otherwise({
            redirectTo: '/list'
        });
    $locationProvider.html5Mode(true);
    $locationProvider.hashPrefix('');
}]);