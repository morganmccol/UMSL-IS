<?php
/*
Author: Ole Fredrik Lie
URL: http://olefredrik.com
*/

// Various clean up functions
require_once('library/cleanup.php');

// Required for Foundation to work properly
require_once('library/foundation.php');

// Register all navigation menus
require_once('library/navigation.php');

// Add menu walkers
require_once('library/menu-walker.php');
require_once('library/offcanvas-walker.php');

// Create widget areas in sidebar and footer
require_once('library/widget-areas.php');

// Return entry meta information for posts
require_once('library/entry-meta.php');

// Enqueue scripts
require_once('library/enqueue-scripts.php');

// Add theme support
require_once('library/theme-support.php');

// Add Header image
require_once('library/custom-header.php');

add_action( 'wp_enqueue_scripts', 'DashScripts' );

function DashScripts(){
//ANGULAR CORE
wp_enqueue_script('angular-core', '//ajax.googleapis.com/ajax/libs/angularjs/1.2.25/angular.min.js', array('jquery'), null, false);
wp_enqueue_script('angular-route', '//ajax.googleapis.com/ajax/libs/angularjs/1.2.25/angular-route.min.js', array('angular-core'), null, false);
wp_enqueue_script('angular-maps', '//maps.googleapis.com/maps/api/js?libraries=places&sensor=false', array('angular-core'), null, false);
wp_enqueue_script('angular-maps', '//maps.googleapis.com/maps/api/js?v=3.exp&signed_in=true&libraries=geometry', array('angular-core'), null, false);

//ANGULAR APP
wp_enqueue_script('angular-app', get_bloginfo('template_directory').'/js/stlportawash/script.js', array('angular-core', 'angular-route'), null, false);
wp_enqueue_script('angular-lodash', get_bloginfo('template_directory').'/js/stlportawash/lodash.min.js', array('angular-core'), null, false);
wp_enqueue_script('angular-google-maps', get_bloginfo('template_directory').'/js/stlportawash/angular-google-maps.min.js', array('angular-core'), null, false);
//wp_enqueue_script('angular-directives', get_bloginfo('template_directory').'/js/angular-directives.js', array('angular-app'), null, false);
//wp_enqueue_script('angular-routes', get_bloginfo('template_directory').'/js/angular-routes.js', array('angular-app'), null, false);
//wp_enqueue_script('angular-factories', get_bloginfo('template_directory').'/js/angular-factories.js', array('angular-app'), null, false);

//ANGULAR CONTROLLERS
//wp_enqueue_script( 'angular-home', get_bloginfo('template_directory').'/js/angular-homeCtrl.js', array('angular-factories'), null, false);
//wp_enqueue_script( 'angular-dash', get_bloginfo('template_directory').'/js/angular-dashCtrl.js', array('angular-factories'), null, false);
//wp_enqueue_script( 'angular-teacher', get_bloginfo('template_directory').'/js/angular-teacherCtrl.js', array('angular-factories'), null, false);
//wp_enqueue_script( 'angular-student', get_bloginfo('template_directory').'/js/angular-studentCtrl.js', array('angular-factories'), null, false);

wp_localize_script('my-scripts', 'myLocalized', array('pages' => trailingslashit( get_bloginfo('template_directory') ) . '/pages'));
}

?>
