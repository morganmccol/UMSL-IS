<?php
/*
Template Name: Portawash Begin
Author: Morgan McCollum
*/
get_header(); ?>

	<?php /* Start loop */ ?>
	<?php while ( have_posts() ) : the_post(); ?>
		<article <?php post_class() ?> id="post-<?php the_ID(); ?>">
			
    <div id="begin">
    <div class="jumbotron text-center">
        <h1>Let's get started.</h1>
        <h3>First, we need to know what type of service you'd like to receive.</h3>

        <div class="container clearfix">
            <div class="row row-centered">
                <div class="col-md-3 col-centered">
                    <div class="selection-highlights">
                        <input class="selection-checkbox" type="checkbox" id="selection-check-1" ng-model="select.commercial" ng-click="commercial=!commercial;" />
                        <div class="selection-highlight"></div>
                    </div>
                    <div class="selection-content" ng-hide="residential">
                        <label class="selection-item" for="selection-check-1">
                            <span class="selection-item-container" ng-class="{green: select.commercial}">
                                <i class="fa fa-truck">
                                </i>
                                <br />Commercial
                            </span>
                        </label>
                    </div>
                </div>

                <div class="col-md-3 col-centered">
                    <div class="selection-highlights" >
                        <input class="selection-checkbox" type="checkbox" id="selection-check-2" ng-model="select.residential" ng-click="residential=!residential" />
                        <div class="selection-highlight"></div>
                    </div>
                    <div class="selection-content" ng-hide="commercial">
                        <label class="selection-item" for="selection-check-2">
                            <span class="selection-item-container" ng-class="{green: select.residential}">
                                <i class="fa fa-home">
                                </i>
                                <br />Residential
                            </span>
                        </label>
                    </div>
                </div>
            </div>

            <svg xmlns="http://www.w3.org/2000/svg" version="1.1" width="800">
                <defs>
                    <filter id="goo">
                        <feGaussianBlur in="SourceGraphic" stdDeviation="9" result="blur" />
                        <feColorMatrix in="blur" mode="matrix" values="1 0 0 0 0  0 1 0 0 0  0 0 1 0 0  0 0 0 20 -6" result="goo" />
                        <feComposite in="SourceGraphic" in2="goo" operator="atop" result="goo" />
                    </filter>
                </defs>
            </svg>

            <div class="row row-centered">
                <div class="col-md-3 col-centered">
                    <a href="">
                        <div ng-show="commercial" ng-animate="'box'" class="commercial-btn">Next</div>
                    </a>
                    <a href="#location" ng-class="{'active': $route.current.activePage == 'location'}">
                        <div ng-show="residential" ng-animate="'box'" class="residential-btn">Next</div>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>
    
<?php get_footer(); ?>
</article>

<?php endwhile; // End the loop ?>