angular.module('UpdateEmisorAppServices', [])
        .factory('UpdateEmisorService', ['$http', function ($http) {
                var handler = {
                        UpdateputEmisor: function (data,Id) {
                                var url = 'https://localhost:5001/api/emisor/'+Id
                                return $http.put(url,data)
                        },

                }

                return handler;
}]);	