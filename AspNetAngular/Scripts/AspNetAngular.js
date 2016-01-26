var AspNetAngular = angular.module('AspNetAngular', ['ngRoute']);

AspNetAngular.controller('LandingPageController', LandingPageController);
AspNetAngular.controller('LoginController', LoginController);
AspNetAngular.controller('RegisterController', RegisterController);

AspNetAngular.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
AspNetAngular.factory('LoginFactory', LoginFactory);
AspNetAngular.factory('RegistrationFactory', RegistrationFactory);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function (params) { return 'routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

AspNetAngular.config(configFunction);
