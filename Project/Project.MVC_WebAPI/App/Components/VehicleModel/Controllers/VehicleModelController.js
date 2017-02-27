app.controller("ModelController", function ($scope, $http) {


    $scope.models = [];
    $http.get('/api/VehicleModel/GetAll')
        .then(function (response) {
            $scope.models = response.data;
            //console.log($scope.models);
        }, function () {
            console.log("Can't get reponse.");
        });

    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;
        $scope.reverse = !$scope.reverse;
    }
});