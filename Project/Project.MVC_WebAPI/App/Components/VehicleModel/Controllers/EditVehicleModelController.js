app.controller("EditVehicleModelController", function ($scope, $http, $stateParams, $location, $window) {

    var id = $stateParams.vmlId;
    //$scope.EditInit = function () {
    //    $http.get('/api/VehicleModel/Get?id=' + id).then(function (response) {
    //        $scope.makeId = response.data.VehicleMakeId;
    //        });
    //}
    $scope.editVehicleMake = function () {
        var vehicle = {
            VehicleModelId: id,
            Name: $scope.Name,
            Abrv: $scope.Abrv
        };
        console.log(vehicle);
        $http.put('/api/VehicleModel/Edit', vehicle)
        .then(function (response) {
            $window.alert("Vehicle model successfully edited.");
            $location.path('/vehicleModel');
        });
    }

    $scope.Close = function () {
        $location.path('/vehicleModel');
    }
});