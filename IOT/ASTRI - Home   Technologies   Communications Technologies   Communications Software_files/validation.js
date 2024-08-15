

function isEmpty(str)
{
	if (str == "" || str.length <= 0)	return true;
	else	return false;
}
function isAlphaSpaceOnly(str)
{
	var patt = /^[a-zA-Z\ ]+$/;
	if (patt.test(str))	 return true;
	else				 return false;
}
function isAlphaNumber(str)
{
	var patt = /^[a-zA-Z0-9]+$/;
	if (patt.test(str))	return true;
	else 				return false;
}
function isNumberOnly(str)
{
	var patt = /^[0-9]+$/;
	if (patt.test(str))	return true;
	else 				return false;
}
function isNumberHyphen(str)
{
	var patt = /^[0-9\-]+$/;
	if (patt.test(str))	return true;
	else 				return false;
}
function isTelFormat(str)
{
	var patt = /^[0-9\-\(\)\ \+]+$/;
	if (patt.test(str))	return true;
	else 				return false;
}
function isCommonLetterOnly(str)
{
	var patt = /^[a-zA-Z0-9\-\'\(\)\.\,\/\ \"\*\#\~\&\@]+$/;
	if (patt.test(str))	 return true;
	else				 return false;
}
function isEmail(str)
{
	var filter  = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	if (filter.test(str))	return true;
	else					return false;
}

function isValidDate(yr,mt,dy)
{
	if (yr < 1900 || yr > 2010)
	{
		return false;
	}

	var maxDayFeb = (yr % 4 == 0) ? 29 : 28;
	var maxDay = 0;

	     if (mt ==  1) maxDay = 31;
	else if (mt ==  2) maxDay = maxDayFeb;
	else if (mt ==  3) maxDay = 31;
	else if (mt ==  4) maxDay = 30;
	else if (mt ==  5) maxDay = 31;
	else if (mt ==  6) maxDay = 30;
	else if (mt ==  7) maxDay = 31;
	else if (mt ==  8) maxDay = 31;
	else if (mt ==  9) maxDay = 30;
	else if (mt == 10) maxDay = 31;
	else if (mt == 11) maxDay = 30;
	else if (mt == 12) maxDay = 31;
	else return false;

	return  (dy > 0 && dy <= maxDay) ? true : false;
}

function isValidHKID4Digits(str)
{
	var re = /[a-zA-Z]+[a-zA-Z0-9]+[0-9]+[0-9]/;

	if(!re.test(str))	 return false;
	else				 return true;
}

function isValidHKIDFormat(str)
{
	var re = /[A-Z][a-z]?\d{6}\([A-Z0-9]\)$/;

	if(!re.test(str))	 return false;
	else				 return true;
}

function isValidHKID(a, n, chk)
{
	if(chk == "a" || chk == "A")
	{
		chk = 10;
	}
	if(chk == 0)
	{
		chk = 11;
	}
	var check_a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	var a_value1=0;
	var a_value2=0;

	// alpha part
	if(a.length == 1)
	{
		for(i=0; i<=25; i++)
		{
			if(a.charAt(0) == check_a.charAt(i))
			{
				a_value2 = i+1;
				a_value1 = 0;
				break;
			}
		}
	}
	else
	{
		for(i=0; i<=25; i++)
		{
			if(a.charAt(0) == check_a.charAt(i))
			{
				a_value1 = i+10;
				break;
			}
		}
		for(i=0; i<=25; i++)
		{
			if(a.charAt(1) == check_a.charAt(i))
			{
				a_value2 = i+10;
				break;
			}
		}
	}
	alpha_total = a_value1 * 9 + a_value2 * 8;
	
	// number part
	number_total = 0;
	var check_n = "0123456789";
	for(i=0; i<n.length; i++)
		number_total += n.charAt(i) * (7-i);

	total = alpha_total + number_total;
	ans = 11 - (total%11);
//	alert(ans);

	if(chk == ans)
		return true;
	else
		return false;
} 


function radioIsChecked(radioBtnGroup)
{
	var isChecked = false;
	for (i=0; i < radioBtnGroup.length; i++)
	{
		if (radioBtnGroup[i].checked) isChecked = true;
	}
	return isChecked;
}