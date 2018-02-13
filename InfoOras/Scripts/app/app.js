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
        when('/orasDetails/:id',
        {
            controller: 'TransportListController',
            templateUrl: 'Orase/orasDetails.html'
        }).
        when('/transportEdit/:id',
        {
            controller: 'TransportEditController',
            templateUrl: 'Orase/transportEdit.html'
        }).
        when('/transportNew',
        {
            controller: 'TransportEditController',
            templateUrl: 'Orase/transportNew.html'
        }).
        when('/transportDelete/:id',
        {
            controller: 'TransportDeleteController',
            templateUrl: 'Orase/transportDelete.html'
        }).
        when('/GMSNew',
        {
            controller: 'GMSEditController',
            templateUrl: 'Orase/GMSNew.html'
        }).
        when('/GMSEdit/:id',
        {
            controller: 'GMSEditController',
            templateUrl: 'Orase/GMSEdit.html'
        }).
        when('/GMSDelete/:id',
        {
            controller: 'GMSDeleteController',
            templateUrl: 'Orase/GMSDelete.html'
        }).
        when('/LocationNew',
        {
            controller: 'LocationEditController',
            templateUrl: 'Orase/LocationNew.html'
        }).
        when('/LocationEdit/:id',
        {
            controller: 'LocationEditController',
            templateUrl: 'Orase/LocationEdit.html'
        }).
        when('/LocationDelete/:id',
        {
            controller: 'LocationDeleteController',
            templateUrl: 'Orase/LocationDelete.html'
        }).
        otherwise({
            redirectTo: '/list'
        });
    $locationProvider.html5Mode(true);
    $locationProvider.hashPrefix('');
}]);
