var novoP = document.createElement("p");
var node = document.createTextNode("Mr. Black e o Osmar Junior são a mesma pessoa");
novoP.appendChild(node);

var NovoElemento = document.getElementById("main1");
NovoElemento.appendChild(novoP);

function SumirP()
{
  var parent = document.getElementById("main2");
  var child = document.getElementById("p4");
  parent.removeChild(child);
}
