angular.module('GetEmisorAppServices', [])
        .factory('GetEmisorService', ['$http', function ($http) {
                var handler = {
                        getEmisor: function () {
                                var url = 'https://localhost:5001/api/emisor'
                                return $http.get(url)
                        },

                }

                return handler;
        }]);	