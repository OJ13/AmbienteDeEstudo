function Teste01()
{
  setInterval(function() { alert("OJ") } ,2000);
}
function Teste02()
{
  setTimeout(function() { alert("OJ is Great Developer") }, 5000);
}

  var x = setInterval(function() {Timer()}, 1000 );

function Timer()
{
  var d = new Date();
  var t = d.toLocaleTimeString();
  document.getElementById("p_clock").innerHTML = t;
}
