/// <reference path="../assets/js/angular.js" />
/// <reference path="../assets/js/angular-route.js" />

angular.module('mainApp')
.config( function ($routeProvider) {
    $routeProvider
   .when('/', {
       templateUrl: './component/dashboard/Dashboard.html',
       controller: 'dashboardCtrl as dash'
   });
});
