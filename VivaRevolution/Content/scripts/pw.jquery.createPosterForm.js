//Hide the preview section onLoad
$(document).ready(function () {
	$('#pw-preview').hide();
});

//Auto fill the hidden Name field with the drop down text value
$("#ImgId").change(function (event) {
	var selectedValue = $("#ImgId option:selected").text();
	$("#Name").val(selectedValue);
});

//Post data to preview controller and show preview of poster
$(".ajaxPreview").click(function (event) {
	event.preventDefault();

	//Values for model
	var values =
		{
			"quote": $("#Quote").val(),
			"imgId": $("#ImgId").val(),
			"name": $("#Name").val(),
			"title": $("#Title").val(),
			"tagLine": $("#TagLine").val()
		}

	//Ajax post to _Preview action method
	//Passes in the model values in the values variable
	//This will return the _preview partial view in the data variable populated with model values
	$.post("/Poster/_Preview", values, function (data) {
		success: {
			$("#DraftPoster").html(data);
			showPreview();
		}
	});

	return false;
});

function showPreview() {
	$('#pw-preview').show();

	//find location of preview div
	var dest = 0;

	if ($('#pw-preview').offset().top > $(document).height() - $(window).height()) {
		dest = $(document).height() - $(window).height();
	} else {
		dest = $('#pw-preview').offset().top;
	}

	//scroll page down to destination
	$('html,body').animate({ scrollTop: dest }, 1000, 'swing');
}