app.controller("MakeController", function ($scope, $http) {


    $scope.makes = [];
    $http.get('/api/VehicleMake/GetAll')
        .then(function (response) {
            $scope.makes = response.data;
            console.log($scope.makes);
        }, function () {
            console.log("Can't get reponse.");
        });

    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;
        $scope.reverse = !$scope.reverse;
    }
});