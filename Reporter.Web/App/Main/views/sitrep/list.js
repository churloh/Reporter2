﻿(function() {
    var app = angular.module('app');

    var controllerId = 'sts.views.sitrep.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.reporter.sitRep',
        function($scope, sitrepService) {
            var vm = this;

            vm.localize = abp.localization.getSource('Reporter');

            vm.sitreps = [];

            $scope.selectedState = 0;

            $scope.$watch('selectedState', function (value) {
                vm.refreshSitReps();
            });

            vm.refreshSitReps = function () {
                abp.ui.setBusy( //Set whole page busy until getSitReps complete
                    null,
                    sitrepService.getSitReps({ //Call application service method directly from javascript
                        state: $scope.selectedState > 0 ? $scope.selectedState : null
                    }).success(function (data) {
                        vm.sitreps = data.sitreps;
                    })
                );
            };

            vm.changeState = function (sitrep) {
                var newState;
                if (sitrep.state == 1) {
                    newState = 2; //Completed
                } else {
                    newState = 1; //Active
                }

                sitrepService.updateSitRep({
                    sitrepId: sitrep.id
                }).success(function () {
                    abp.notify.info(vm.localize('SitRepUpdatedMessage'));
                });
            };

            vm.getSitRepCountText = function () {
                return abp.utils.formatString(vm.localize('XSitReps'), vm.sitreps.length);
            };
        }
    ]);
})();