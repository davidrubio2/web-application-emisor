var GetEmisor = angular.module("GetEmisor", ['GetEmisorAppServices']);
GetEmisor.controller("GetAllEmisorController", ['$scope', 'GetEmisorService', function ($scope, GetEmisorService) {

        $scope.GetEmisorAppServices = []

        GetEmisorService.getEmisor().then(function (response) {
                $scope.emisor = response.data;
        });
}]);
