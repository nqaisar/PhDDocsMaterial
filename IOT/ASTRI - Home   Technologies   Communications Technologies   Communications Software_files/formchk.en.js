function formchk_contactus()
{
	// Check title (radio)
	if (!radioIsChecked(document.form_contactus.title))
	{
		alert("Please select your title.");
		document.form_contactus.title[0].focus();
		return false;
	}
	// Check name
	if (isEmpty(document.getElementById('last_name').value))
	{
		alert("Please enter your last name.");
		document.getElementById('last_name').focus();
		return false;
	}
	if (isEmpty(document.getElementById('first_name').value))
	{
		alert("Please enter your first name.");
		document.getElementById('first_name').focus();
		return false;
	}
	
	// Check email
	if (isEmpty(document.getElementById('email').value) || !isEmail(document.getElementById('email').value))
	{
		alert("Please enter a valid email address.");
		document.getElementById('email').focus();
		return false;
	}
	// Check tel
	if (!isEmpty(document.getElementById('tel').value) && !isTelFormat(document.getElementById('tel').value))
	{
		alert("Please enter a valid contact phone number.");
		document.getElementById('tel').focus();
		return false;
	}
	// Check fax
	if (!isEmpty(document.getElementById('fax').value) && !isTelFormat(document.getElementById('fax').value))
	{
		alert("Please enter a valid fax number.");
		document.getElementById('fax').focus();
		return false;
	}
	
	return true;
}