<?php
/*
Template Name: Portawash Home
Author: Morgan McCollum
*/
get_header(); ?>

	<?php /* Start loop */ ?>
	<?php while ( have_posts() ) : the_post(); ?>
		<article <?php post_class() ?> id="post-<?php the_ID(); ?>">
			
			<?php
$image1 = wp_get_attachment_image_src( get_field('slider-1'), 'slider-size' );
$image2 = wp_get_attachment_image_src( get_field('slider-2'), 'slider-size' );
$image3 = wp_get_attachment_image_src( get_field('slider-3'), 'slider-size' );
?>
 
<?php // The first field is mandatory: ?>
<ul data-orbit>
  <li>
    <img src="<?php echo $image1[0]; ?>" alt="" />
  </li>
  <?php if(get_field('slider-2')) { // Subsequent fields are not mandatory ?>
  <li>
    <img src="<?php echo $image2[0]; ?>" alt="" />
  </li>
  <?php } ?>
  <?php if(get_field('slider-3')) { ?>
  <li>
    <img src="<?php echo $image3[0]; ?>" alt="" />
  </li>
  <?php } ?>
</ul>

<section id="about">
    <div class="row">
    <div class="medium-12 columns">
        <div class="about-title">
            <h1>A portable powerwashing service</h1>
            <h4>Located in St Louis, Missouri</h4>
        </div>
        </div>
    
         <div class="about-features">
        <div class="medium-4 columns">
            <i class="fa fa-university"></i>
            <h5>Established</h5>
            <p>We have been in business since 1997 and provide the best quality and affordable service in the industry.</p>
        </div>
        <div class="medium-4 columns">
            <i class="fa fa-map-marker"></i>
            <h5>Local</h5>
            <p>We provide service in the St. Louis metropolitan and surrounding area including Missouri and Illinois.</p>
        </div>
        <div class="medium-4 columns">
            <i class="fa fa-lock"></i>
            <h5>Insured</h5>
            <p>We have liablility insurance and can provide many positive referrals from satisfied former customers.</p>
        </div>
        </div>
    </div>
</section>

<section id="services">
    <div class="row">
        <div class="medium-12 columns">
            <div class="services-title">
                <h1>Here's what we offer</h1>
                <h4>Choose between our available services</h4>
            </div
        </div>

        <div class="medium-6 small-12 columns">
            <div class="pricing right">
                <div class="pricing-title">
                    Commercial
                </div>
                <div class="content">
                    <div class="sub-title">
                        For businesses.
                    </div>
                    <ul>
                        <li>Truck and Trailer Washing</li>
                        <li>Sidewalks</li>
                        <li>Drive Thrus</li>
                        <li>Parking Garages</li>
                        <li>Concrete Sealing</li>
                        <li>Gas Stations</li>
                        <li>Apartments</li>
                        <li>Parking Lots</li>
                        <li>Heavy Equipment</li>
                    </ul>
                    <a href="#">
                        Call us at (314) 303-7581
                    </a>
                </div>
            </div>
        </div>
                
        <div class="medium-6 small-12 columns">
            <div class="pricing">
                <div class="pricing-title">
                        Residential
                </div>
                <div class="content">
                    <div class="sub-title">
                            For homes.
                    </div>
                    <ul>
                        <li>Vinyl Siding</li>
                        <li>Patios</li>
                        <li>Sidewalks</li>
                        <li>Decks</li>
                        <li>Driveways</li>
                        <li>Gutters</li>
                        <li>Pools</li>
                        <li>Garages</li>
                        <li>Concrete Sealing</li>
                    </ul>
                    <a href="booking/index.html">
                        Book online
                    </a>
                </div>
            </div>
        </div>
    </div>     
</section>

<section id="testimonials">
    <div class="row">
        <div class="medium-12 columns">
            <div class="services-title">
                <h1>What others have said</h1>
                <h4>Hear from our satisfied customers</h4>
            </div
        </div>
        
        <div class="medium-4 columns">  
            <div class="bubble">
                <p>"<?php the_field('excerpt-1'); ?>"</p>
            </div>
            <h5><?php the_field('name-1'); ?></h5>
        </div>
        
        <div class="medium-4 columns">  
            <div class="bubble">
                <p>"<?php the_field('excerpt-2'); ?>"</p>
            </div>
            <h5><?php the_field('name-2'); ?></h5>
        </div>
        
        <div class="medium-4 columns">  
            <div class="bubble">
                <p>"<?php the_field('excerpt-3'); ?>"</p>
            </div>
            <h5><?php the_field('name-3'); ?></h5>
        </div>
    </div>
</section>

<section id="faq">
    <div class="row">
        <div class="medium-12 columns">
            <div class="faq-title">
                <h1>Have a question?</h1>
                <h4>We have answers</h4>
            </div
        </div>
        
        <div class="medium-12 columns">
        <div class="accordion">
        <span class="target-fix" id="accordion"></span>
        <div>
            <span class="target-fix" id="accordion1"></span>
            <a href="#accordion1" id="open-accordion1" title="open">How far in advance should I schedule services?</a>
            <a href="#accordion" id="close-accordion1" title="close">How far in advance should I schedule services?</a> 
            <div class="accordion-content">
                <p>Typically, your job can be scheduled within a weeks notice.</p>
            </div>
        </div>

        <div>
            <span class="target-fix" id="accordion2"></span>
            <a href="#accordion2" id="open-accordion2" title="open">When is payment due?</a>
            <a href="#accordion" id="close-accordion2" title="close">When is payment due?</a>
            <div class="accordion-content">
                <p>For residential jobs, payment is expected at completion of job.</p>       
            </div>
        </div>

        <div>
            <span class="target-fix" id="accordion3"></span>
            <a href="#accordion3" id="open-accordion3" title="open">Is there anything I need to do to prepare for service?</a>
            <a href="#accordion" id="close-accordion3" title="close">Is there anything I need to do to prepare for service?</a>
            <div class="accordion-content">
                <p>No, most outdoor furniture can be moved away from the exterior by us.
                Please make sure all windows are shut and cars are removed from driveway.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion4"></span>
            <a href="#accordion4" id="open-accordion4" title="open">Do you clean windows?</a>
            <a href="#accordion" id="close-accordion4" title="close">Do you clean windows?</a>
            <div class="accordion-content">
                <p>No, we do not clean windows.
                However, we can refer you to a window cleaning contractor for after the job is completed.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion5"></span>
            <a href="#accordion5" id="open-accordion5" title="open">How does the weather affect power washing?</a>
            <a href="#accordion" id="close-accordion5" title="close">How does the weather affect power washing?</a>
            <div class="accordion-content">
                <p>We can work in most weather conditions, however 60 degress or warmer is the optimal termperature for residential cleaning.
                Some cleaners react better to warmer temperatures, thus providing better results.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion6"></span>
            <a href="#accordion6" id="open-accordion6" title="open">How much does it cost to clean the outside of a house?</a>
            <a href="#accordion" id="close-accordion6" title="close">How much does it cost to clean the outside of a house?</a>
            <div class="accordion-content">
                <p>The average cost of cleaning the outside of a house(includes brushing gutters) is typically between $0.10 and $0.18
                per real estate square footage of the house.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion7"></span>
            <a href="#accordion7" id="open-accordion7" title="open">Do you clean the inside of gutters?</a>
            <a href="#accordion" id="close-accordion7" title="close">Do you clean the inside of gutters?</a>
            <div class="accordion-content">
                <p>For an additional fee, the inside of the gutters can be cleaned out.
                On some 2 story homes, we may not be able to clean the inside of the gutters.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion8"></span>
            <a href="#accordion8" id="open-accordion8" title="open">I have pets, will chemicals be used around my house?</a>
            <a href="#accordion" id="close-accordion8" title="close">I have pets, will chemicals be used around my house?</a>
            <div class="accordion-content">
                <p>Diluted chemicals are used to fight tough stains and we use properly mixed ratios of those cleaners.
                            We use environmentally safe cleaners to ensure the best possible improvements to your property.
                            Due to other factors, such as having to leave gates open, using ladders and pulling hoses and for everyone's safety, we ask that you please have all pets secured inside the home.</p>
            </div>
        </div>
        
        <div>
            <span class="target-fix" id="accordion9"></span>
            <a href="#accordion9" id="open-accordion9" title="open">What are the small black spots all over the siding on my house?</a>
            <a href="#accordion" id="close-accordion9" title="close">What are the small black spots all over the siding on my house?</a>
            <div class="accordion-content">
                <p>Artillery fungus is a white-rotting, wood-decay fungus that likes to live on moist landscape mulch.
                The spore masses of the artillery fungus stick like super-glue.
                We have not found a way to get them off without leaving a stain or damaging the siding, especially on old dry siding.
                Power washing may work on brand new(only) vinyl siding that still has a shiny, oily, sheen.</p>
            </div>
        </div>
        </div>
        </div>
    </div>
</section>

<section id="contact">
    <div class="row">
        <div class="medium-12 columns">
            <div class="contact-title">
                <h1>Reach out to us</h1>
                <h4>We'd love to hear from you</h4>
            </div
        </div>
        
        <div class="medium-8 medium-centered columns">
            <?php if( function_exists( 'ninja_forms_display_form' ) ){ ninja_forms_display_form( 1 ); } ?>
        </div>
    </div>
</section
    
<?php get_footer(); ?>
</article>

<?php endwhile; // End the loop ?>