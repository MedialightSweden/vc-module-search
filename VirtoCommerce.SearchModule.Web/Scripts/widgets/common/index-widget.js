angular.module('virtoCommerce.searchModule')
.controller('virtoCommerce.searchModule.indexWidgetController', ['$scope', 'platformWebApp.bladeNavigationService', 'virtoCommerce.searchModule.search', function ($scope, bladeNavigationService, searchApi) {
    var blade = $scope.blade;
    $scope.loading = true;

    function refresh() {
        searchApi.query({ documentType: $scope.widget.documentType, documentId: blade.currentEntityId }, function (data) {
            if (_.any(data)) {
                $scope.index = data[0];
                // 621355968000000000 ticks of Microsoft's DateTime is start of Unix epoch - Jan 1 1970 12:00 AM UTC
                // 10000 Microsoft's DateTime ticks is 1 millisecond
                $scope.indexDate = new Date(($scope.index.lastindexdate - 621355968000000000) / 10000);
            }

            $scope.loading = false;
            updateStatus();
        });
    }

    function updateStatus() {
        if (!$scope.loading && blade.currentEntity) {
            $scope.widget.UIclass = !$scope.index || ($scope.indexDate < new Date(blade.currentEntity.modifiedDate)) ? 'error' : '';
        }
    }

    $scope.openBlade = function () {
        var newBlade = {
            id: 'detailChild',
            currentEntityId: blade.currentEntityId,
            data: $scope.index,
            indexDate: $scope.indexDate,
            documentType: $scope.widget.documentType,
            parentRefresh: refresh,
            title: blade.currentEntity.name,
            subtitle: 'search.blades.index-detail.subtitle',
            controller: 'virtoCommerce.searchModule.indexDetailController',
            template: 'Modules/$(VirtoCommerce.Search)/Scripts/blades/index-detail.tpl.html'
        };

        if (!$scope.index) {
            angular.extend(newBlade, {
                title: 'search.blades.index-detail.title-new',
                subtitle: undefined,
            });
        }

        bladeNavigationService.showBlade(newBlade, blade);
    };

    $scope.$watch('blade.currentEntity', updateStatus);

    refresh();
}]);
