app.controller("AddVehicleModelController", function ($scope, $http, $location, $window) {

    $scope.getMakers = function () {
        $http.get('/api/VehicleMake/GetAll')
        .then(function (response) {
            $scope.makers = response.data;

        }, function (response) {
            $window.alert(response.data.Message);
        })
    }

    $scope.addVehicleModel = function () {
        var vehicle = {
            VehicleMakeId: $scope.selectedMaker.Id,
            Name: $scope.Name,
            Abrv: $scope.Abrv
        };
        $http.post('/api/VehicleModel/Add', vehicle)
        .then(function (data) {
            $scope.response = data;
            $window.alert("Successfully added!");
            $location.path('/vehicleModel');
        });
    }
});