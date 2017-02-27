app.controller("EditVehicleMakeController", function ($scope, $http, $stateParams, $location, $window) {

    var id = $stateParams.vmkId;

    $scope.editVehicleMake = function () {
        var vehicle = {
            Id: id,
            Name: $scope.Name,
            Abrv: $scope.Abrv
        };
        console.log(vehicle);
        $http.put('/api/VehicleMake/Edit', vehicle)
        .then(function (response) {
            $window.alert("Vehicle maker successfully edited.");
            $location.path('/vehicleMake');
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleMake');
    }
});