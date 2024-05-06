// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var loadMoreCount = 1;
$(".load-more-btn").on("click", function () {
    loadMoreCount++;
    var x = $("#listings-container .card");
    for (var i = 3; i < x.length; i++) {
        if (i < loadMoreCount * 3)
            $(x[i]).show();
        else
            $(x[i]).hide();
        
    }
    if (x.length <= loadMoreCount * 3 || x.length >= loadMoreCount * 3 -2)
        $("#loadMore").hide();
    
    //$("#listings-container .card").show();
})

$(function () {
    var x = $("#listings-container .card");
    for (var i = 0; i < x.length; i++)
    {
        if (i < 3)
            $(x[i]).show();
        else
            $(x[i]).hide();
    }
    if (x.length == 3)
        $("#loadMore").hide();
})
    
    
   // $("#listings-container .card[1]").show();


    //var x = $(".card");
    //for (var i = 0; i < x.length; i++) {
    //    if (x[i].attributes.data.value <= 3) {
    //        $("#listings-container .card[i]").show();
    //        if (x[i].attributes.data.value == x.length)
    //            $("#readMoreButton").hide();
    //    }
    //    else {
    //        $("#readMoreButton").hide();
    //    }
    //}


