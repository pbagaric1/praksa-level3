app.controller("DetailsVehicleMakeController", function ($scope, $http, $stateParams, $location) {

    var id = $stateParams.vmkId;

    $scope.detailsVehicleMake = function () {
        $http.get('/api/VehicleMake/Get?id=' + id)
        .then(function (response) {
            $scope.Name = response.data.Name;
            $scope.Abrv = response.data.Abrv;
            console.log(id);
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleMake');
    }
});