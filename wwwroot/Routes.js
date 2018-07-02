'use strict';

var EmisorApp = angular.module('EmisorApp', ['ngRoute', 'SaveEmisor','GetEmisor','UpdateEmisor','DeleteEmisor']);
EmisorApp.config(['$routeProvider',
    function (
        $routeProvider
    ) {
        $routeProvider.
            when('/SaveEmisor', {
                templateUrl: 'pages/SaveEmisorPage.html',
                controller: 'SaveEmisorController'
            }).
            when('/GetEmisor', {
                templateUrl: 'pages/GetAllEmisorPage.html',
                controller: 'GetAllEmisorController'
            }).
            when('/UpdateEmisor', {
                templateUrl: 'pages/UpdateEmisorPage.html',
                controller: 'UpdateEmisorController'
            }).
            when('/DeleteEmisor', {
                templateUrl: 'pages/DeleteEmisorPage.html',
                controller: 'DeleteEmisorController'
            }).
            otherwise({
                redirectTo: '/SaveEmisor'
            });
    }]);