var OrasApp = angular.module('OrasApp', ['ngRoute', 'OrasController']);

OrasApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.when('/list',
        {
            controller: 'ListController',
            templateUrl: 'Orase/list.html'
        }).
        when('/create',
        {
            controller: 'EditController',
            templateUrl: 'Orase/edit.html'
        }).
        when('/edit/:id',
        {
            controller: 'EditController',
            templateUrl: 'Orase/edit.html'
        }).
        when('/view/:id',
        {
            controller: 'ViewController',
            templateUrl: 'Orase/view.html'
        }).
        when('/delete/:id',
            {
                controller: 'DeleteController',
                templateUrl: 'Orase/delete.html'
            }).
        otherwise({
            redirectTo: '/list'
        });
    $locationProvider.html5Mode(true);
    $locationProvider.hashPrefix('');
}]);
