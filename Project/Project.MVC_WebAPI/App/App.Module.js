var app = angular.module('app', ['ui.router']);

app.config(function($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/vehicleMake');

    $stateProvider
    .state('vehicleMake', {
        url: '/vehicleMake',
        views: {
            "root": {
                templateUrl: 'App/Components/VehicleMake/HtmlPage1.html'
            }
        }
    });
});