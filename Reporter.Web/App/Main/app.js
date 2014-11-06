(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in ReporterNavigationProvider
                })
                .state('sitreplist', {
                    url: '/sitreps',
                    templateUrl: '/App/Main/views/sitrep/list.cshtml',
                    menu: 'SitRepList' //Matches to name of 'SitRepList' menu in ReporterNavigationProvider
                })
                /*
                .state('newtask', {
                    url: '/new',
                    templateUrl: '/App/Main/views/sitrep/new.cshtml',
                    menu: 'NewTask' //Matches to name of 'NewTask' menu in SimpleTaskSystemNavigationProvider
                })*/
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in ReporterNavigationProvider
                });
        }
    ]);
})();