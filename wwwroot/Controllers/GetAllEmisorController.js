var GetEmisor = angular.module("GetEmisor", ['GetEmisorAppServices']);
GetEmisor.controller("GetAllEmisorController", ['$scope', 'GetEmisorService', function ($scope, GetEmisorService) {

        $scope.GetEmisorAppServices = []

        GetEmisorService.getEmisorFun().then(function (response) {
                $scope.emisor = response.data;
        });
}]);
