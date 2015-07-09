'use strict';
(function (angular) {
    var statsApp = angular.module('statsApp', ['ngRoute'])

    statsApp.config([
        '$routeController',
        function($routeProvider) {
            $routeProvider
                .when('/Stats', {
                    templateUrl: 'partials/BasicOverviewPage.html',
                    controller: 'outputCtrl'
                })
                .when('/a', {
                    templateUrl: 'Views/HomePage.html',
                    controller: 'outputCtlr'
                })
                .otherwise({
                    redirectTo: '/'
                });
        }
    ]);
    statsApp.controller('outputCtlr', [
            '$scope', '$location',
            function($scope) {
                $scope.stringss = "Hello World";

                $scope.callPage = function(value) {
                    if (true) {
                        $scope.hello = 13;
                        //$scope.$location.path('/helloworld')
                    }
                }
            }
        ]
    );
})(window.angular);