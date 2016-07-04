<?php
/*
Template Name: Portawash Booking
Author: Morgan McCollum
*/
get_header(); ?>

	<?php /* Start loop */ ?>
	<?php while ( have_posts() ) : the_post(); ?>
		<article <?php post_class() ?> id="post-<?php the_ID(); ?>">
			
    <div id="booking" ng-controller="mainController">
        <nav class="navbar" ng-controller="navController">
            <div class="container">
                <ul class="nav-booking">
                    <li><a href="#booking" ng-class="{'active': $route.current.activePage == 'begin'}"><i class="fa fa-square-o fa-1x"></i><span> Begin</span></a></li>
                    <li><a href="#location" ng-class="{'active': $route.current.activePage == 'location'}"><i class="fa fa-square-o"></i><span> Location</span></a></li>
                    <li><a href="#house" ng-class="{'active': $route.current.activePage == 'house'}"><i class="fa fa-square-o"></i><span> Residence</span></a></li>
                    <li><a href="#services" ng-class="{'active': $route.current.activePage == 'services'}"><i class="fa fa-square-o"></i><span> Services</span></a></li>
                    <li><a href="#quote" ng-class="{'active': $route.current.activePage == 'quote'}"><i class="fa fa-square-o"></i><span> Quote</span></a></li>
                    <li><a href="#schedule" ng-class="{'active': $route.current.activePage == 'schedule'}"><i class="fa fa-square-o"></i><span> Schedule</span></a></li>
                    <li><a href="#end" ng-class="{'active': $route.current.activePage == 'end'}"><i class="fa fa-square-o"></i><span> Finish</span></a></li>
                </ul>
            </div>
        </nav>

        <div id="main">
            <div ng-view></div>
        </div>
    </div>
    
<?php get_footer(); ?>
</article>

<?php endwhile; // End the loop ?>