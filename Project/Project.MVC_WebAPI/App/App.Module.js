var app = angular.module('app', ['ui.router', 'angularUtils.directives.dirPagination']);

app.config(function($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/vehicleMake');

    $stateProvider
        .state('vehicleMake', {
            url: '/vehicleMake',
            controller: 'VehicleMakeController',
            views: {
                "root": {
                    templateUrl: 'App/Components/VehicleMake/Views/IndexVehMake.html'
                }
            }
        })
        .state('vehicleMakeAdd', {
            url: '/addVehicleMake',
            controller: 'AddVehicleMakeController',
            views: {
                "root": {
                    templateUrl: 'App/Components/VehicleMake/Views/AddVehMake.html'
                }
            }
        })
        .state('vehicleMakeDelete', {
            url: '/deleteVehicleMake:vmkId',
            controller: 'DeleteVehicleMakeController',
            views: {
                "root": {
                    templateUrl: 'App/Components/VehicleMake/Views/DeleteVehMake.html'
                }
            }
        })
     .state('vehicleMakeEdit', {
         url: '/editVehicleMake:vmkId',
         controller: 'EditVehicleMakeController',
         views: {
             "root": {
                 templateUrl: 'App/Components/VehicleMake/Views/EditVehMake.html'
             }
         }
     })
    .state('vehicleMakeDetails', {
        url: '/detailsVehicleMake:vmkId',
        controller: 'DetailsVehicleMakeController',
        views: {
            "root": {
                templateUrl: 'App/Components/VehicleMake/Views/DetailsVehMake.html'
            }
        }
    })
     .state('vehicleModel', {
         url: '/vehicleModel',
         controller: 'VehicleModelController',
         views: {
             "root": {
                 templateUrl: 'App/Components/VehicleModel/Views/IndexVehModel.html'
             }
         }
     })
    .state('vehicleModelAdd', {
        url: '/addVehicleModel',
        controller: 'AddVehicleModelController',
        views: {
            "root": {
                templateUrl: 'App/Components/VehicleModel/Views/AddVehModel.html'
            }
        }
    })
        .state('vehicleModelDelete', {
            url: '/deleteVehicleModel:vmlId',
            controller: 'DeleteVehicleModelController',
            views: {
                "root": {
                    templateUrl: 'App/Components/VehicleModel/Views/DeleteVehModel.html'
                }
            }
        })
     .state('vehicleModelEdit', {
         url: '/editVehicleModel:vmlId',
         controller: 'EditVehicleModelController',
         views: {
             "root": {
                 templateUrl: 'App/Components/VehicleModel/Views/EditVehModel.html'
             }
         }
     })
    .state('vehicleModelDetails', {
        url: '/detailsVehicleModel:vmlId',
        controller: 'DetailsVehicleModelController',
        views: {
            "root": {
                templateUrl: 'App/Components/VehicleModel/Views/DetailsVehModel.html'
            }
        }
    });
});