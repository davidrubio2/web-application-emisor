angular.module('SaveEmisorAppServices', [])
        .factory('SaveEmisorService', ['$http', function ($http) {
                var handler = {
                        putEmisor: function (data) {
                                var url = 'https://localhost:5001/api/emisor'
                                return $http.post(url, data)
                        },
                }

                return handler;
        }]);