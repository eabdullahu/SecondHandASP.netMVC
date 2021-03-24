var Cookie = {
	setCookie: function (key, value, expiry) {
	    var expires = new Date();
	    expires.setTime(expires.getTime() + (expiry * 24 * 60 * 60 * 1000));
	    document.cookie = key + '=' + value + ';path=/' + ';expires=' + expires.toUTCString();
	}, 
	getCookie: function (key) {
	    var keyValue = document.cookie.match('(^|;) ?' + key + '=([^;]*)(;|$)');
	    return keyValue ? keyValue[2] : null;
	},
	eraseCookie: function (key) {
	    var keyValue = Cookie.getCookie(key);
	    Cookie.setCookie(key, keyValue, '-1');
	}
}

$('.banner').owlCarousel({
	loop:true,
	nav:true,		
	autoplay:false,
	dots:false,
	margin:30,
	navText: ["<i class='flaticon-left-arrow'></i>","<i class='flaticon-right-arrow-angle'></i>"],
	items:1
});

$(".wishlist-delete").click(function () {
	var remove = $(this).closest("div.item");
	setTimeout(function () {
		remove.fadeOut(500, function () {
			remove.remove();
			if ($(".products .item").length <= 0) {
				$("#wishlistEmpty").fadeIn();
			}
		});
	}, 500);
});

$("body").on("click", ".wishlist", function() {
	var texts = ["Add to wishlist", "Remove from wishlist"];
	var icons = ["<i class='flaticon-like'></i>", "<i class='flaticon-close'></i>", "<i class='flaticon-loading-circle'></i>"];

	var element = $(this);
	var pid = element.closest('div.item').attr("p-id");
	if (!pid) {
		pid = element.closest('div.product-content').attr("p-id")
	}

	console.log(pid);

	element.html(icons[2]);
	element.find("i").addClass("added-wishlist");

	if(Cookie.getCookie(pid)){
		Cookie.eraseCookie(pid);
		setTimeout(function () {
			element.html(icons[0]);
			element.attr("aria-label", texts[0]);
			element.find("i").removeClass("added-wishlist");
		},1500);
	} else {
		Cookie.setCookie(pid, pid, 30);
		setTimeout(function () {
			element.html(icons[1]);
			element.attr("aria-label", texts[1]);
			element.find("i").removeClass("added-wishlist");
		},1500);
	}
});

function quantityVal(elem){
	var input_value = parseInt(elem.val());
	var input_min = parseInt(elem.attr("min"));
	var input_max = parseInt(elem.attr("max"));
	return {"element": elem, "value": input_value, "min": input_min, "max": input_max};
}

$(".quantity-dec").click(function() {
	var qty = quantityVal($(this).siblings(".quanity-val"));
	if(qty['value'] - 1 >= qty['min']) 
		qty['element'].val(qty['value'] - 1);
});
$(".quantity-inc").click(function() {
	var qty = quantityVal($(this).siblings(".quanity-val"));
	if(qty['value'] + 1 <= qty['max']) 
		qty['element'].val(qty['value'] + 1);
});

$(".hamburger-menu").click(function() {
	$('.mobile-menu-overlay, .mobile-menu-container').toggleClass('show');
	$(this).toggleClass('opened').attr('aria-expanded', $(this).hasClass('opened'));
});

$(".description-reviews .tablist .tabs").click(function (){
	var index = $(this).index();
	$(".description-reviews .tablist .tabs").removeClass("active").eq(index).addClass("active");
/*$(".description-reviews .contents > div").fadeOut(300).eq(index).delay(300).fadeIn();*/
	$(".description-reviews .contents > div").slideUp().eq(index).slideDown();
});

$(".indicator-container").click(function (){
	$("#shopping-container").toggleClass("show");
	$("#shopping-overlay").toggleClass("show");
});

var toDelete = null;
var clicked = null;
function ajaxCall(pid, url, callback) {
	$.ajax({
		type: "POST",
		url: url,
		dataType: "json",
		data: { "pid": pid },
		success: eval(callback)
	});
}

function removeFromCart(response) { /* Modal that shows on button click on right side*/
	if (response[0] == "success") {
		toDelete.remove();
		if ($(".shopping-products > div.shopping-single-product").length < 1) {
			$(".indicator").text(0);
			$("#shopping-cart-prices").fadeOut(300);
			$("#shopping-cart-empty").delay(300).fadeIn();
		}
		$(".indicator").text(response[2]);
		$("#cart-total-price").text(response[1] + " \u20AC");
	} else {
		clicked.find("i").attr("class", "flaticon-close").removeClass("shopping-cart-remove");
		alert("There was an error, please try again.");
	}
}
function removeFromCart2(response) { /* Shopping cart page */
	if (response[0] == "success") {
		if ($(".view-cart-container table tbody tr").length <= 1) {
			$(".view-cart-container table tfoot th button").addClass("disabled");
			$("#shopping-total-price").html("0.00");
			toDelete.html("<td class='align-center' colspan='6'>Your shopping cart is empty.</td>");
		} else {
			toDelete.remove();
        }
		$(".indicator").text(response[2]);
		$("#shopping-total-price").text(response[1]);
	} else {
		clicked.find("i").attr("class", "flaticon-close").removeClass("shopping-cart-remove");
		alert("There was an error, please try again.");
    }
}

$("body").on("click", ".remove-product", function () { /* Modal that shows on button click on right side*/
	toDelete = $(this).closest("div.shopping-single-product");
	clicked = $(this);
	clicked.find("i").attr("class", "flaticon-loading-circle").addClass("shopping-cart-remove");
	setTimeout(function () {
		ajaxCall(toDelete.attr("p-id"), "/Cart/removeFromCart", "removeFromCart");
	}, 1500);
});
$("body").on("click", ".remove-product-cart", function () { /* Shopping cart page */
	toDelete = $(this).closest("tr");
	clicked = $(this);
	clicked.find("i").attr("class", "flaticon-loading-circle").addClass("shopping-cart-remove");
	setTimeout(function () {
		ajaxCall(clicked.attr("p-id"), "/Cart/removeFromCart", "removeFromCart2");
	}, 1500);
});

$("body").on("click", ".buy", function () {
	if (!$(this).hasClass("soldout")) {
		var p_id = $(this).closest("div.item").attr("p-id");
		var quantity = 1;
		if (!p_id) {
			p_id = $(this).closest("div.product-content").attr("p-id");
			quantity = $(".quanity-val").val();
        }
		$.ajax({
			type: "POST",
			url: "/Cart/addToCart",
			dataType: "json",
			data: { "pid": p_id, "quantity": quantity },
			success: function (data) {
				if (data[0] == "error") {
					alert(data[2]);
				} else {
					$("#shopping-cart-prices").fadeIn();
					$("#shopping-cart-empty").fadeOut();
					$("#cart-total-price").text(data[3] + " \u20AC");
					$(".indicator").text(data[1]);
					$(".shopping-products").prepend(data[2]);
					$(".indicator-container").click();
				}
			}
		});
    }
});

$(".close-open").click(function() {
	$(this).parent("li.menu-has-children").siblings("li.menu-has-children").find("ul.sub-menu").slideUp();
	$(this).parent("li.menu-has-children").siblings("li.menu-has-children").find(".close-open").attr("class", "flaticon-plus close-open");
	if($(this).siblings("ul.sub-menu").is(":hidden")){
		$(this).siblings("ul.sub-menu").slideDown();
		$(this).attr("class", "flaticon-remove close-open");
	}else {
		$(this).siblings("ul.sub-menu").slideUp();
		$(this).attr("class", "flaticon-plus close-open");
	}
});

$("#open-filters").click(function() {
	$(".search-divider > div.search").slideToggle();
});

$(".checkout-mobile-orders").click(function() {
	var txt = ["Show order summary", "Hide order summary", "flaticon-down-arrow", "flaticon-up-arrow-angle"];
	if($(".cart-container").is(":hidden")){
		$(".cart-container").slideDown();
		$(this).find("span#checkout-desc-label").html(txt[1]);
		$(this).find("i#checkout-up-down-icon").attr("class", txt[2]);
	}else {
		$(".cart-container").slideUp();
		$(this).find("span#checkout-desc-label").html(txt[0]);
		$(this).find("i#checkout-up-down-icon").attr("class", txt[3]);
	}
});

$(function () {
	$('.slider-image').slick({
	  	slidesToShow: 1,
	  	slidesToScroll: 1,
	  	arrows: true,
	  	fade: true,
	  	dots: true,
	  	asNavFor: '.slider-nav',
	  	prevArrow:"<button type='button' class='slick-arrow slick-prev'><i class='flaticon-left-arrow'></i></button>",
        nextArrow:"<button type='button' class='slick-arrow slick-next'><i class='flaticon-right-arrow-angle'></i></button>"
	});
	$('.slider-nav').slick({
	  	slidesToShow: 3,
	  	slidesToScroll: 1,
	  	asNavFor: '.slider-image',
	  	dots: false,
	  	centerMode: true,
	  	focusOnSelect: true,
	  	arrows: false,
	  	vertical: true,
	  	verticalSwiping: true,
	});
});

$(document).ready(function () {

	setTimeout(function () {
		$('.updated-succ').fadeOut();
	}, 5000);


	setTimeout(function () {
		$('.updated-fail').fadeOut();
	}, 5000);
});

$('.delete-prd').click(function () {
	$('#delete_msg').fadeIn("slow");
	$('.out-msg').click(function () {
		$('#delete_msg').fadeOut("slow");
	})

});