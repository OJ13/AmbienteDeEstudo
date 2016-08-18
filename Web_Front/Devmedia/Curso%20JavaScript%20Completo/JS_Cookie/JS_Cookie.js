function setCookie()
{
  var nome = prompt("Por favor entre com seu nome:", "Nome");
  var exdias = 365;
  var exdata = new Date();
  exdata.setDate(exdata.getDate() + exdias);
  var cok_value = escape(nome) + ((exdias == null)?"":"; expires = " + exdata.toUTCString());
  document.cookie = "nome = " + cok_value;
}
function lerCookie()
{
  var cookie_value = document.cookie;
  var cookie_start = cookie_value.indexOf("nome = ");
  if (cookie_start == -1) {
    cookie_start = cookie_start.indexOf("nome = ");
  }
  if (cookie_start == -1) {
    cookie_value = null;
  }else {
    cookie_start = cookie_value.indexOf("=", cookie_start)+1;
    var cookie_end = cookie_value.indexOf(";", cookie_start);
    if (cookie_end == -1) {
      cookie_end = cookie_value.length;
    }
    cookie_value = unescape(cookie_value.substring(cookie_start, cookie_end));
  }
  alert("O valor armazenado do cookie é " + cookie_value);
}
