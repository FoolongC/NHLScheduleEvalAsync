$(document).ready(function () {

	$(".renderaction").each(function (i, n) {
		var $n = $(n),
			url = $n.attr('data-actionurl'),
			$this = $(this);
		$this.append("<div class='teamContainer teamNameHeader'>Team Name: <b>" + $this.attr('id') + "</b></div>");
		$this.append(
			"<div class='sk-fading-circle spinner'>" +
			"<div class='sk-circle1 sk-circle'></div>" +
			"<div class='sk-circle2 sk-circle'></div>" +
			"<div class='sk-circle3 sk-circle'></div>" +
			"<div class='sk-circle4 sk-circle'></div>" +
			"<div class='sk-circle5 sk-circle'></div>" +
			"<div class='sk-circle6 sk-circle'></div>" +
			"<div class='sk-circle7 sk-circle'></div>" +
			"<div class='sk-circle8 sk-circle'></div>" +
			"<div class='sk-circle9 sk-circle'></div>" +
			"<div class='sk-circle10 sk-circle'></div>" +
			"<div class='sk-circle11 sk-circle'></div>" +
			"<div class='sk-circle12 sk-circle'></div>" +
			"</div>"
			);
		$.get(url, function (data) {
			$this.html(data);
		});
	});

	$(".renderaction").click(function () {
		$(this).closest('div').find('.gameInfoToggle').toggle();
		});
});