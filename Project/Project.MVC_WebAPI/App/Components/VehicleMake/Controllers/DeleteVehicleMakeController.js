app.controller("DeleteVehicleMakeController", function ($scope, $http, $stateParams, $location, $window) {

    var id = $stateParams.vmkId;
    console.log(id);

    $scope.deleteVehicleMake = function () {
        
        $http.delete('/api/VehicleMake/Delete?id=' + id)
        .then(function (data) {
            $scope.response = data;
            $window.alert("Vehicle maker successfully deleted.");
            $location.path('/vehicleMake');
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleMake');
    }
});