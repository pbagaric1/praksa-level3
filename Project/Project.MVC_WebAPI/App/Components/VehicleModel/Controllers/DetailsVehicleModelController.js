app.controller("DetailsVehicleModelController", function ($scope, $http, $stateParams, $location) {

    var id = $stateParams.vmlId;

    $scope.detailsVehicleModel = function () {
        $http.get('/api/VehicleModel/Get?id=' + id)
        .then(function (response) {
            $scope.VehicleMakeName = response.data.VehicleMake.Name;
            $scope.Name = response.data.Name;
            $scope.Abrv = response.data.Abrv;
            console.log(id);
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleModel');
    }
});