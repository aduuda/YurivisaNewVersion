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
            items: 5
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
