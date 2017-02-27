app.controller("DeleteVehicleModelController", function ($scope, $http, $stateParams, $location, $window) {

    var id = $stateParams.vmlId;
    console.log(id);

    $scope.deleteVehicleModel = function () {

        $http.delete('/api/VehicleModel/Delete?id=' + id)
        .then(function (data) {
            $scope.response = data;
            $window.alert("Vehicle model successfully deleted.");
            $location.path('/vehicleModel');
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleModel');
    }
});