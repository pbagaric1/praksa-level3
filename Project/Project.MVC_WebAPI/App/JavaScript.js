/// <reference path="D:\praksa-level3\Project\Project.MVC_WebAPI\Scripts/angular.min.js" />
var app = angular.module('app', []);

app.controller("myController", function ($scope, $http) {
    $scope.vehicles = [];
            $http.get('http://localhost:50696/api/VehicleMake/GetAll')
                .then(function (response) {
                    $scope.vehicles = response.data;
                });
        });