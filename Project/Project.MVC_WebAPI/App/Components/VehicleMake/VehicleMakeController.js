/// <reference path="D:\praksa-level3\Project\Project.MVC_WebAPI\Scripts/angular.min.js" />
/// <reference path="../../App.Module.js" />


//var app = angular.module('app', []);

app.controller("MakeController", function ($scope, $http) {


    $scope.makes = [];
    $http.get('/api/VehicleMake/GetAll')
        .then(function (response) {
            $scope.makes = response.data;
            console.log($scope.makes);
        }, function () {
            console.log("Can't get reponse.");
        });
});