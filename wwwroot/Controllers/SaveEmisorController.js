var SaveEmisor = angular.module("SaveEmisor", ['SaveEmisorAppServices']);
SaveEmisor.controller("SaveEmisorController", ['$scope', 'SaveEmisorService', function ($scope, SaveEmisorService) {
        $scope.SaveEmisorAppServices = []
        $scope.newEmisor = function () {
                var data = {
                        "Id": $scope.Id,
                        "Rfc": $scope.Rfc,
                        "FechaInicioOperacion": $scope.FechaInicioOperacion ,
                        "Capital": $scope.Capital
                }
                SaveEmisorService.putEmisor(data).then(function (response) {
                        $scope.SaveEmisorAppServices.push(response.data)
                });
			$scope.Id = null;
			$scope.Rfc = null;
			$scope.FechaInicioOperacion = null;
			$scope.Capital = null;
        }
}]);

