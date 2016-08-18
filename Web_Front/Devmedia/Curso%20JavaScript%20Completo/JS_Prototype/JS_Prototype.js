function teste01()
{
  var d = $('dv_01');
  alert(d.innerHTML);
}
function teste02()
{
  var divs = $('dv_01','dv_02');

  for(var i = 0; i < divs.length; i++)
  {
    alert(divs[i].innerHTML);
  }
}
function teste03()
{
  alert($F('txtUser'));
}
