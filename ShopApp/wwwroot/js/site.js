$(document).ready(function () {
	var $num = $('#quantity').val();
	$('#add').click(function () {
		$num++;
		$('#quantity').val($num);

	});

	$('#minus').click(function () {



		$num--;
		$('#quantity').val($num);




	});

	$('#size').change(function () {
		if ($(this).val() == "Small") {
			alert($(this).val());
			$('#quantity').attr({
				'max': 10,
				'min': 2
			});
		}
		else if ($(this).val() == "Medium") {
			alert("ela oo");
			$('#quantity').attr({
				'max': '10',
				'min': 2
			});
		}
		else if ($(this).val() == "Large") {
			alert("ela oo");
		}
		else
		{

		}

	});







});