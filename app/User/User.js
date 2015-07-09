'use strict';
var controllerId = 'user';
angular.module('app').controller(controllerId, ['common', '$scope', '$http', user]);

function user(common, $scope, $http) {
    /// <summary></summary>
    /// <param name="common" type=""></param>
    var getLogFn = common.logger.getLogFn;
    var log = getLogFn(controllerId);

    var vm = this;
    //var id;
    var promiseOfTeam = $http.get('api/stats/TeamTable');
    promiseOfTeam.then(function (payload) {
        $scope.teamTable = payload.data;
        //$scope.id = payload.data;
        //alert(payload.data);
    });

    var promiseOfPlayer = $http.get('api/stats/PlayerTable');
    promiseOfPlayer.then(function (payload) {
        $scope.playerTable = payload.data;
        //$scope.id = payload.data;
        //alert(payload.data);
    });

    var team = "XYZ";
    $scope.sortPlayers = function (teamValue, teamName) {
        //alert(teamValue);
        team = teamValue;
        $scope.TTeam = teamName;
        return teamValue;
    }

    $scope.filterPlayersFielders = function (player) {
        if (team == "") {
            return true;
        } else if (player.Team == team) {
            if (player.Position == "P") {
                return false;
            } else {
                return true;
            }
        } else {
            return false;
        }
    }

    $scope.filterPlayersPitchers = function (player) {
        if (team == "") {
            return true;
        } else if (player.Team == team) {
            if (player.Position == "P") {
                return true;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

    vm.title = 'MLB TEAMS AND PLAYERS';
    activate();

    function activate() {
        common.activateController([], controllerId)
            .then(
                function () {
                    log('Activated User View');
                }
            );
    }
}