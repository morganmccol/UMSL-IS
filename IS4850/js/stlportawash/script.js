var portaApp = angular.module('portaApp', ['ngRoute']);

portaApp.config(function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);

    $routeProvider
        .when('/booking', {
            templateUrl: 'wp-content/themes/stlportawash/pages/begin.html',
            controller: 'mainController',
            activePage: 'begin'
        })
        .when('/location', {
            templateUrl: 'wp-content/themes/stlportawash/pages/location.html',
            controller: 'locationController',
            activePage: 'location'
        })
        .when('/house', {
            templateUrl: 'wp-content/themes/stlportawash/pages/house.html',
            controller: 'houseController',
            activePage: 'house'
        })
        .when('/services', {
            templateUrl: 'wp-content/themes/stlportawash/pages/services.html',
            controller: 'servicesController',
            activePage: 'services'
        })
        .when('/quote', {
            templateUrl: 'wp-content/themes/stlportawash/pages/quote.html',
            controller: 'quoteController',
            activePage: 'quote'
        })
        .when('/schedule', {
            templateUrl: 'wp-content/themes/stlportawash/pages/schedule.html',
            controller: 'scheduleController',
            activePage: 'schedule'
        })
        .when('/end', {
            templateUrl: 'wp-content/themes/stlportawash/pages/end.html'
        })
        .when('/commercial', {
            templateUrl: 'wp-content/themes/stlportawash/pages/commercial.html'
        })
        .otherwise({
            redirectTo: "/"
        });
});

function navController($scope, $route) {
    $scope.$route = $route;
}

portaApp.controller('mainController', function ($scope) {
});

portaApp.controller('locationController', function ($scope) {
    $scope.Good = false;
    $scope.Bad = false;

    var mapOptions = {
        center: { lat: 38.68, lng: -90.46 },
        zoom: 8
    };

    var image = {
        url: 'wp-content/themes/stlportawash/assets/img/marker.png'
    }

    var map = new google.maps.Map(document.getElementById('map'),
        mapOptions);
    $scope.Search = function () {
        $scope.Good = false;
        $scope.Bad = false;
        var address = $scope.address;
        var radius = parseInt(50, 10) * 1000;
        var marker_start = new google.maps.Marker({
            position: { lat: 38.688757, lng: -90.464391 },
            map: map,
            icon: image,
            title: "STL PortaWash"
        });

        var populationOptions = {
            strokeColor: '#66FF99',
            strokeOpacity: 0.2,
            strokeWeight: 2,
            fillColor: '#66FF99',
            fillOpacity: 0.35,
            map: map,
            center: new google.maps.LatLng(38.68, -90.46),
            radius: 80000
        };

        var cityCircle = new google.maps.Circle(populationOptions);
        var lat = '';
        var lng = '';
        var geocoder = new google.maps.Geocoder();
        var marker_user = null;

        geocoder.geocode({ 'address': address }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                lat = results[0].geometry.location.lat();
                lng = results[0].geometry.location.lng();
                marker_user = new google.maps.Marker({
                    position: { lat: lat, lng: lng },
                    map: map,
                    animation: google.maps.Animation.DROP,
                    title: "Your Location"
                });

                if (google.maps.geometry.spherical.computeDistanceBetween(marker_user.getPosition(), marker_start.getPosition()) < 80000)
                    $scope.$apply(function () { $scope.Good = true; });
                else
                    $scope.$apply(function () { $scope.Bad = true; });
            }
        });
    };
});

portaApp.controller('houseController', function ($scope) {
});

portaApp.controller('servicesController', function ($scope) {
    this.service = serviceTypes;

    this.calculateHours = function () {
        var totalHours = 0;
        for (var i = 0; i < this.service.length; i++) {
            if (this.service[i].selected == true)
                totalHours += this.service[i].hours;
        };
        return totalHours;
    };
});

portaApp.controller('quoteController', function ($scope) {
    this.service = serviceTypes;
    this.customer = customerData;
});

portaApp.controller('scheduleController', function ($scope) {
});

portaApp.controller('finalController', function ($scope) {
});

portaApp.controller('focusController', function ($scope) {
    $scope.$watch('focus', function (v) {
        $scope.chosenPlace = v;
    });
});

portaApp.directive('googleplace', function () {
    return {
        require: 'ngModel',
        scope: {
            ngModel: '=',
            details: '=?'
        },
        link: function (scope, element, attrs, model) {
            var options = {
                types: [],
                componentRestrictions: {}
            };
            scope.gPlace = new google.maps.places.Autocomplete(element[0], options);

            google.maps.event.addListener(scope.gPlace, 'place_changed', function () {
                scope.$apply(function () {
                    scope.details = scope.gPlace.getPlace();
                    model.$setViewValue(element.val());
                });
            });
        }
    };
});

portaApp.controller('focusController', function ($scope, $http) {
    $scope.customerInput = customerData;

    $scope.$watch("focus", function (newVal) {
        $scope.formData.search = $scope.chosenPlaceDetails.address_components[0].long_name + ' ' + $scope.chosenPlaceDetails.address_components[1].long_name;
    });
    $scope.formData = {};
    $scope.submission = false;
    var param = function (data) {
        var returnString = '';
        for (d in data) {
            if (data.hasOwnProperty(d))
                returnString += d + '=' + data[d] + '&';
        }
        return returnString.slice(0, returnString.length - 1);
    };
    $scope.submitForm = function () {
        $scope.customerInput.totalSqFt = null;

        $http({
            method: 'POST',
            url: 'wp-content/themes/stlportawash/php/zillow.php',
            data: param($scope.formData),
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        })
            .success(function (data) {
                $scope.formData = {};
                $scope.submission = true;
                $scope.customerInput.totalSqFt = data.messageSuccess;
                var numCheck = Number($scope.customerInput.totalSqFt);
                if (isNaN(numCheck)) {
                    $scope.customerInput.errorMessage = "No square footage could be found for this address. Please enter it below.";
                    $scope.customerInput.successMessage = "";
                } else {
                    $scope.customerInput.successMessage = "Success!";
                    $scope.customerInput.errorMessage = "";
                }
            });
    };
});

var customerData = {
    name: undefined,
    phone: undefined,
    email: undefined,
    address: undefined,
    totalSqFt: undefined,
    errorMessage: undefined
};

var serviceTypes = [
    {
        name: "Vinyl Siding",
        idName: "vinyl",
        hours: 1,
        icon: "fa-home",
    },
    {
        name: "Patio",
        idName: "patio",
        hours: 1,
        icon: "fa-leaf"
    },
    {
        name: "Sidewalk",
        idName: "sidwalk",
        hours: 1,
        icon: "fa-chain"
    },
    {
        name: "Deck",
        idName: "deck",
        hours: 1,
        icon: "fa-pagelines"
    },
    {
        name: "Driveway",
        idName: "driveway",
        hours: 1,
        icon: "fa-car"
    },
    {
        name: "Gutters",
        idName: "gutters",
        hours: 1,
        icon: "fa-umbrella"
    },
    {
        name: "Pool",
        idName: "pool",
        hours: 1,
        icon: "fa-tint"
    },
    {
        name: "Garage",
        idName: "garage",
        hours: 1,
        icon: "fa-wrench"
    },
    {
        name: "Concrete",
        idName: "concrete",
        hours: 1,
        icon: "fa-align-justify"
    }
];

portaApp.controller('dateController', [
    '$scope', '$http', function ($scope, $http) {

        this.weekday = weekdays;

        this.customerInput = customerData;

        this.selectDate = function (startTime, endTime) {
            customerData.startTime = startTime;
            customerData.endTime = endTime;
        }

        $http.get('wp-content/themes/stlportawash/php/calendar.php')
            .success(function (data) {
                JSON.stringify(data);

                weekdays[0].date = data.monday;
                weekdays[1].date = data.tuesday;
                weekdays[2].date = data.wednesday;
                weekdays[3].date = data.thursday;
                weekdays[4].date = data.friday;

                weekdays[0].start8 = data.monstart8;
                weekdays[0].start11 = data.monstart11;
                weekdays[0].start2 = data.monstart2;

                weekdays[0].end11 = data.monend11;
                weekdays[0].end2 = data.monend2;
                weekdays[0].end5 = data.monend5;

                weekdays[1].start8 = data.tuestart8;
                weekdays[1].start11 = data.tuestart11;
                weekdays[1].start2 = data.tuestart2;

                weekdays[1].end11 = data.tueend11;
                weekdays[1].end2 = data.tueend2;
                weekdays[1].end5 = data.tueend5;

                weekdays[2].start8 = data.wedstart8;
                weekdays[2].start11 = data.wedstart11;
                weekdays[2].start2 = data.wedstart2;

                weekdays[2].end11 = data.wedend11;
                weekdays[2].end2 = data.wedend2;
                weekdays[2].end5 = data.wedend5;

                weekdays[3].start8 = data.thustart8;
                weekdays[3].start11 = data.thustart11;
                weekdays[3].start2 = data.thustart2;

                weekdays[3].end11 = data.thuend11;
                weekdays[3].end2 = data.thuend2;
                weekdays[3].end5 = data.thuend5;

                weekdays[4].start8 = data.fristart8;
                weekdays[4].start11 = data.fristart11;
                weekdays[4].start2 = data.fristart2;

                weekdays[4].end11 = data.friend11;
                weekdays[4].end2 = data.friend2;
                weekdays[4].end5 = data.friend5;
            });
    }
]);

var weekdays = [
    {
        dayName: "Monday",
        dayId: "mon",
        date: null,
        start8: null,
        end11: null,
        start11: null,
        end2: null,
        start2: null,
        end5: null
    },
        {
            dayName: "Tuesday",
            dayId: "tue",
            date: undefined,
            start8: undefined,
            end11: undefined,
            start11: undefined,
            end2: undefined,
            start2: undefined,
            end5: undefined
        },
        {
            dayName: "Wednesday",
            dayId: "wed",
            date: undefined,
            start8: undefined,
            end11: undefined,
            start11: undefined,
            end2: undefined,
            start2: undefined,
            end5: undefined
        },
        {
            dayName: "Thursday",
            dayId: "thu",
            date: undefined,
            start8: undefined,
            end11: undefined,
            start11: undefined,
            end2: undefined,
            start2: undefined,
            end5: undefined
        },
        {
            dayName: "Friday",
            dayId: "fri",
            date: undefined,
            start8: undefined,
            end11: undefined,
            start11: undefined,
            end2: undefined,
            start2: undefined,
            end5: undefined
        }
];


var customerData = {
    name: undefined,
    phone: undefined,
    email: undefined,
    address: undefined,
    totalSqFt: undefined,
    startTime: undefined,
    endTime: undefined,
    errorMessage: undefined
};

var serviceTypes = [
    {
        name: "Vinyl Siding",
        idName: "vinyl",
        hours: 1,
        icon: "fa-home",
    },
    {
        name: "Patio",
        idName: "patio",
        hours: 1,
        icon: "fa-leaf"
    },
    {
        name: "Sidewalk",
        idName: "sidwalk",
        hours: 1,
        icon: "fa-chain"
    },
    {
        name: "Deck",
        idName: "deck",
        hours: 1,
        icon: "fa-pagelines"
    },
    {
        name: "Driveway",
        idName: "driveway",
        hours: 1,
        icon: "fa-car"
    },
    {
        name: "Gutters",
        idName: "gutters",
        hours: 1,
        icon: "fa-umbrella"
    },
    {
        name: "Pool",
        idName: "pool",
        hours: 1,
        icon: "fa-tint"
    },
    {
        name: "Garage",
        idName: "garage",
        hours: 1,
        icon: "fa-wrench"
    },
    {
        name: "Concrete",
        idName: "concrete",
        hours: 1,
        icon: "fa-align-justify"
    }
];