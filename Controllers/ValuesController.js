'use strict';

(function () {
    var mainCtlr = angular.module('mainCtlr', [])

    .config(function ($locationProvider) {
        $locationProvider.html5Mode(true).hashPrefix('!');
    })
})();