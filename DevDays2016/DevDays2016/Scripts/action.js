
$(function(){
	$("li.day01 a").click(function(){
		$('html,body').animate({scrollTop: $('#day01').offset().top},1000);
	});
   $("li.day02 a").click(function(){
		$('html,body').animate({scrollTop: $('#day02').offset().top},1000);
	});
	$("li.day03 a").click(function(){
		$('html,body').animate({scrollTop: $('#day03').offset().top},1000);
	});

	$(".gotop").click(function(){
        $("html,body").animate({scrollTop:0},1000);
    });

	// 控制 div 開闔

	
	$("#hack nav li.intro a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.intro" ).addClass("select");
		$("#intro").fadeIn();
		$("#creat,#know,#hack_agenda,#award,#regulation,#reference").css("display","none");
	});

	$("#hack nav li.creat a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.creat" ).addClass("select");
		$("#creat").fadeIn();
		$("#intro,#know,#hack_agenda,#award,#regulation,#reference").css("display","none");
	});

	$("#hack nav li.know a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.know" ).addClass("select");
		$("#know").fadeIn();
		$("#intro,#creat,#hack_agenda,#award,#regulation,#reference").css("display","none");
	});

	$("#hack nav li.agenda a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.agenda" ).addClass("select");
		$("#hack_agenda").fadeIn();
		$("#intro,#creat,#know,#award,#regulation,#reference").css("display","none");
	});

	$("#hack nav li.award a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.award" ).addClass("select");
		$("#award").fadeIn();
		$("#intro,#creat,#know,#hack_agenda,#regulation,#reference").css("display","none");
	});

	$("#hack nav li.regulation a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.regulation" ).addClass("select");
		$("#regulation").fadeIn();
		$("#intro,#creat,#know,#hack_agenda,#award,#reference").css("display","none");
	});

	$("#hack nav li.reference a").click(function(){
		$("#hack nav li" ).removeClass("select");
		$("#hack nav li.reference" ).addClass("select");
		$("#reference").fadeIn();
		$("#intro,#creat,#know,#hack_agenda,#award,#regulation").css("display","none");
	});
});
