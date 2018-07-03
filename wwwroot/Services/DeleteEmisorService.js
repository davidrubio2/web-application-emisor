angular.module('DeleteEmisorAppServices', [])
        .factory('DeleteEmisorService', ['$http', function ($http) {
                var handler = {
                        DeleteputEmisor: function (Id) {
                                var url = 'https://localhost:5001/api/emisor/'+Id
                                return $http.delete(url)
                        },

                }

                return handler;
}]);