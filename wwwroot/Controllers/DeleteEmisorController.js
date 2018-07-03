var DeleteEmisor = angular.module("DeleteEmisor", ['DeleteEmisorAppServices']);
DeleteEmisor.controller("DeleteEmisorController", ['$scope', 'DeleteEmisorService', function ($scope, DeleteEmisorService) {
        $scope.DeleteEmisorAppServices = []
        $scope.DeletenewEmisor = function () {
               
                 DeleteEmisorService.DeleteputEmisor($scope.Id).then(function (response) {
                        $scope.DeleteEmisorAppServices.push(response)
                });
			$scope.Id = null;
			
        }
}]);