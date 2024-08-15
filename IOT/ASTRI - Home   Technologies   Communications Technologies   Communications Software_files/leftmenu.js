var lastClick = "";
var submenu_lv2 = "";
var submenu_lv3 = "";
var lastClickStatus = "";

function expandMenuLv2(obj)
{
	if(document.getElementById(obj+"_status").value ==0)
	{	
		if(submenu_lv3!="") {
			//Effect.BlindUp(submenu_lv2,{duration:0.3});
			expandMenuLv3(submenu_lv3);
		}
		if(submenu_lv2!="") {
			//Effect.BlindUp(submenu_lv2,{duration:0.3});
			$("#"+ submenu_lv2).slideUp();
			submenu_lv2 = "";
		}
		if(lastClick!="") {
			$("#"+ lastClick).slideUp();
			//Effect.BlindUp(lastClick,{duration:0.3});
			document.getElementById(lastClickStatus).value = 0;

		}
			$("#"+ obj).slideDown();
		//Effect.BlindDown(obj,{duration:0.7});
		document.getElementById(obj+"_status").value = "1";
		lastClick = obj;
		lastClickStatus = obj+"_status";
	}else{
		//Effect.BlindUp(obj,{duration:0.3});
		$("#"+ obj).slideUp();
		document.getElementById(obj+"_status").value = "0";
	}	
}

function expandMenuLv3(obj) 
{
	//if(lastClick!="") Effect.BlindUp(lastClick,{duration:0.6});
	if(document.getElementById(obj+"_status").value ==0)
	{
		$("#"+ obj).slideDown();
		//Effect.BlindDown(obj,{duration:0.7});
		document.getElementById(obj+"_status").value = "1";
		submenu_lv3 = obj;
	}else{
		$("#"+ obj).slideUp();
		//Effect.BlindUp(obj,{duration:0.4});
		document.getElementById(obj+"_status").value = "0";
		submenu_lv3 = "";
	}	
}
function expandMenu(obj){
	$("#"+ obj).show();
}
function highlightLv1Css(obj){
	$("#"+obj).removeClass("leftmenu_lv1");
	$("#"+obj).addClass("leftmenu_lv1_highlighted");
}
function highlightLv2Css(obj){
	$("#"+obj).removeClass("leftmenu_lv2");
	$("#"+obj).addClass("leftmenu_lv2_highlighted");
}
function highlightLv3Css(obj){
	$("#"+obj).removeClass("leftmenu_lv3");
	$("#"+obj).addClass("leftmenu_lv3_highlighted");
}

function highlightLv1(objId_lv1)
{
	highlightLv1Css(objId_lv1);
}

function highlightLv2(objId_lv1,divId_lv2,objId_lv2)
{
	expandMenuLv2(divId_lv2);
	
	highlightLv1Css(objId_lv1);
	highlightLv2Css(objId_lv2);
	submenu_lv2 = divId_lv2;
}

function highlightLv3(objId_lv1,divId_lv2,objId_lv2,divId_lv3,objId_lv3)
{
	expandMenuLv2(divId_lv2);
	expandMenuLv3(divId_lv3);
	highlightLv1Css(objId_lv1);
	highlightLv2Css(objId_lv2);
	highlightLv3Css(objId_lv3);
	submenu_lv2 = divId_lv2;
	submenu_lv3 = divId_lv3;
}
