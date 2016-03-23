$(document).ready(function () {

	$(".renderaction").each(function (i, n) {
		var $n = $(n),
		url = $n.attr('data-actionurl'),
		$this = $(this);
		$this.append("<div class='teamContainer teamNameHeader'>Team Name: <b>" + $this.attr('id') + "</b></div>");
		$this.append(
			"<div id='fadingCircle' class='sk-fading-circle spinner'>" +
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

	var listByCount = 0;

	$(".teamsByCount").click(function () {
		$(".partialViewContainer").toggle();
		$(this).toggle();
		$(".teamsByAlpha").toggle();
		$(".APIContainer").show();
		$("#teamGridCount").show();

		if (listByCount == 0) {
			$("#teamGridCount").prepend(
			"<div style='margin-left:2px;' class='sk-fading-circle spinner'>" +
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
			$.getJSON("api/teamcount")
				.done(function (data) {
				    $(".APIContainer").prepend("<div class='containerHeader'>Ajax call to Web API 2 Controller</div>");
					$.each(data, function (key, item) {
						$("#teamGridCount").append("<div id='" + item.Team.TeamName.replace(/\./g, ' ').replace(/ /g, '')
							+ "' class='teamNameHeader fade-in renderaction'>"
							+ "Team Name: <b>"
							+ item.Team.TeamName + " </b>Games Played: <b>"
							+ item.Team.Count + "</b></div>");

						item.Team.LstGameInfo.forEach(function (entry) {
							$("#teamGridCount").append("<div class='gameInfoToggle fade-in "
								+ item.Team.TeamName.replace(/\./g, ' ').replace(/ /g, '') + "'>"
								+ "<span class='gameInfoRow1'>Game One Date: "
								+ entry.GameOneDate
								+ " - Game 1 Home: " + entry.GameOneHome
								+ " | Game 2 Home: " + entry.GameTwoHome
								+ " - " + entry.FinalGameOne
								+ "</span><br/>"
								+ "<span class='gameInfoRow2'>Game Two Date: "
								+ entry.GameTwoDate
								+ " - Opp. Played Day Before: "
								+ entry.OpponentPlayedDayBefore
								+ " - " + entry.FinalGameTwo
								+ "</span></div>");
						})                        
					});
					$(".sk-fading-circle").remove();
				});
		}
		listByCount = 1;
	});

	$(".teamsByAlpha").click(function () {
		$(this).toggle();
		$(".partialViewContainer").toggle();
		$(".APIContainer").toggle();
		$("#teamGridCount").hide();
		$(".teamsByCount").toggle();
	});

	$(document).on('click', '.teamNameHeader', function (e) {
		var thisId = $(this).attr('id');
		$('.' + thisId).toggle();
	});

	$(".renderaction").click(function () {
		$(this).closest('div').find('.gameInfoToggle').toggle();
	});
});