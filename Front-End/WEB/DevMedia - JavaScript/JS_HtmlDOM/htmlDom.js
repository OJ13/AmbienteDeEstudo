function testeEncontrarPorId()
{
  x = document.getElementById("demo");
  alert(x.innerHTML);
}
function testeEncontrarPelaTagName()
{
  var x = document.getElementById("main");
  var y = x.getElementsByTagName("p");

  alert(y[0].innerHTML);
}
