var UpdateEmisor = angular.module("UpdateEmisor", ['UpdateEmisorAppServices']);
UpdateEmisor.controller("UpdateEmisorController", ['$scope', 'UpdateEmisorService', function ($scope, UpdateEmisorService) {
        $scope.UpdateEmisorAppServices = []
        $scope.UpdatenewEmisor = function () {
                var data = {
                        "Rfc": $scope.Rfc,
                        "FechaInicioOperacion": $scope.FechaInicioOperacion ,
                        "Capital": $scope.Capital
                }
                 UpdateEmisorService.UpdateputEmisor(data,$scope.Id).then(function (response) {
                        $scope.UpdateEmisorAppServices.push(response.data)
                });
			$scope.Id = null;
			$scope.Rfc = null;
			$scope.FechaInicioOperacion = null;
			$scope.Capital = null;
        }
}]);