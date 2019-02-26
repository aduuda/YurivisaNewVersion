//$('.owl-carousel').owlCarousel({
//    loop: true,
//    margin: 10,
//    nav: true,
//    responsive: {
//        0: {
//            items: 1
//        },
//        600: {
//            items: 3
//        },
//        1000: {
//            items: 5
//        }
//    }
//})
$(document).ready(
    function () {
        var currentPath = window.location.pathname;
        console.log(currentPath);
        $("#MainNavContainer .nav-item").each(function () {

            var link = $(this);
            var src = link.find("a").attr("href");
            console.log(src);
            if (currentPath === src) {

                $(this).addClass("active");
            }
            else {

                $(this).removeClass("active");
            }
        });
    });
var $animation_elements = $('.animation-element');
var $window = $(window);

function check_if_in_view() {
    var window_height = $window.height();
    var window_top_position = $window.scrollTop();
    var window_bottom_position = (window_top_position + window_height);

    $.each($animation_elements, function () {
        var $element = $(this);
        var element_height = $element.outerHeight();
        var element_top_position = $element.offset().top;
        var element_bottom_position = (element_top_position + element_height);

        //check to see if this current container is within viewport
        if ((element_bottom_position >= window_top_position) &&
            (element_top_position <= window_bottom_position)) {
            $element.addClass('in-view');
        } else {
            $element.removeClass('in-view');
        }
    });
}

$window.on('scroll resize', check_if_in_view);
$window.trigger('scroll');
$(document).ready(function () {
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll > 50) {
            $("#MainNav").css("background-color", "rgba(254, 249, 250,0.7)");
            console.log(scroll);
        }
    });
});
$('#gallery').owlCarousel({
    loop: true,
    margin: 10,
    nav: true,
    navText: [
        "<i class='fas fa-arrow-left'></i>",
        "<i class='fas fa-arrow-right'></i>"
    ],
    autoplay: true,
    autoplayHoverPause: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 3
        },
        1000: {
            items: 4
        }
    }
})
$('#customer').owlCarousel({
    loop: true,
    margin: 10,
    nav: true,
    navText: [
        "<i class='fas fa-arrow-left'></i>",
        "<i class='fas fa-arrow-right'></i>"
    ],
    autoplay: true,
    autoplayHoverPause: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 2
        },
        1000: {
            items: 4
        }
    }
})
