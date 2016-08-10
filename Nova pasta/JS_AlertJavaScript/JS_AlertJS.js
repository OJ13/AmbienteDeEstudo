function alertBox(){
    alert("Este é um Alert Box!");
}
function confirmBox()
{
  var resultado;
  var press = confirm("Você é um Desenvolvedor?");

  if (press == true) {
    resultado = "Você pressionou o OK, é um Desenvolvedor!"
  }else {
    resultado = "Você Cancelou, não é Dev!";
  }
  document.getElementById("p_show").innerHTML = resultado;
}
function promptBox()
{
  var resultado;
  var car = prompt("Por favor, qual seu carro favorito?","Cadillac");

  if (car != null) {
    resultado = "Seu carro favorito é " + car;
    document.getElementById("lb_show").innerHTML = resultado;
  }
}
