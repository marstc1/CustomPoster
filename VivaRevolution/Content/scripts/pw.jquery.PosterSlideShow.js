$("#slideshow > div:gt(0)").hide();
$('#bullets > div:first').addClass('selected');

setInterval(function () {

    $('#slideshow > div:first')
        .fadeOut(500)
        .next()
        .delay(1000)
        .fadeIn(500)
        .end()
        .appendTo('#slideshow');

    $('#bullets > div:first')
        .removeClass('selected')
        .next()
        .addClass('selected')
        .end()
        .appendTo('#bullets');

}, 10000);

function setSelectedDiv() {
    if ($("#pw-poster1").is(":visible")) {
        $('#bullet1').addClass("selected");
    }
    else {
        $('#bullet1').removeClass("selected");
    }
};