function goBack()
{
  window.history.back();
}
function goNext()
{
  window.history.forward();
}
function showInfo()
{
  var txtInfo = "<p>Browser: " + navigator.appVersion + "</p>";
  txtInfo += "<p>Cookies habilitados: " + navigator.cookieEnabled + "</p>";
  txtInfo += "<p>Plataforma: " + navigator.plataform + "</p>";
  txtInfo += "<p>User-Agent header: "+ navigator.userAgent + "</p>";

  document.getElementById("dv_Info").innerHTML = txtInfo;
}
