function ShowSize()
{
  var largura = screen.availWidth;
  var altura = screen.availHeight;
  document.getElementById("p_largura").innerHTML = largura;
  document.getElementById("p_altura").innerHTML = altura;
}
function showUrl()
{
  var atualURL = location.href;
  document.getElementById("p_url").innerHTML = atualURL;
}
function showSite()
{
  window.location.assign("http://www.devmedia.com.br");
}
