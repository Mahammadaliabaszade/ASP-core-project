(function ($) {
    $(document).ready(function () {
       
            
           


        let skip = 6;
        $(document).on('click', '#loadMore', function () {
            let coursecount = $('#Coursecount').val()
            $.ajax({
                url: "/Course/LoadMore?skip=" + skip,
                type: "Get",
                success: function (res) {
                    $(".courseelement").append(res)
                    skip += 6
                    if (coursecount <= skip) {
                        $('#loadMore').remove();
                    }
                }


            })

                

        })
       

        
    "use strict";  
    })
    $(document).ready(function () {

            let skip2 = 6;
            $(document).on('click', '#loadMore2', function () {
                let eventcount = $('#eventcount').val()
                $.ajax({
                    url: "/Event/LoadMore?skip2=" + skip2,
                    type: "Get",
                    success: function (res) {
                        $(".eventelement").append(res)
                        skip2 += 6
                        if (eventcount <= skip2) {
                            $('#loadMore2').remove();
                        }
                    }


                })



            })



        



        "use strict";
    })
    $(document).ready(function () {

        let skip3 = 8;
        $(document).on('click', '#loadMore3', function () {
            let tcount = $('#tcount').val()
            $.ajax({
                url: "/Teacher/LoadMore?skip3=" + skip3,
                type: "Get",
                success: function (res) {
                    $(".telement").append(res)
                    skip3 += 8
                    if (tcount <= skip3) {
                        $('#loadMore3').remove();
                    }
                }


            })



        })







        "use strict";
    })
    $(document).ready(function () {

        let skip4 = 6;
        $(document).on('click', '#loadMore4', function () {
            let bcount = $('#bcount').val()
            $.ajax({
                url: "/Blog/LoadMore?skip4=" + skip4,
                type: "Get",
                success: function (res) {
                    $(".belement").append(res)
                    skip4 += 6
                    if (bcount <= skip4) {
                        $('#loadMore4').remove();
                    }
                }


            })



        })







        "use strict";
    })
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    
    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
     $('body').scrollspy({ 
            target: '.navbar-collapse',
            offset: 95
        });
$(".notice-left").niceScroll({
            cursorcolor: "#EC1C23",
            cursorborder: "0px solid #fff",
            autohidemode: false,
            
        });

})(jQuery);	