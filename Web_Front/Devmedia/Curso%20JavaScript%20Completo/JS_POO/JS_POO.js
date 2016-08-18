/*function car(speed)
{
  //alert("Class Car Instanciada");
  this.speed = speed;
}

car.prototype.msg_speed = "Esta é a mensagem de Velocidade";
car.prototype.setSpeed = function(speed)
{
  this.speed = speed;
  alert("Velocidade do carro foi alterada");
}

var car1 = new car(40);
var car2 = new car(60);

alert("Carro 1 Speed: " + car1.speed);
alert("Carro 2 Speed: " + car2.speed);

alert(car1.msg_speed);

car1.setSpeed(120);
car2.setSpeed(140);

alert("Carro 1 velocidade: " + car1.speed);
alert("Carro 2 velocidade: " + car2.speed);
*/
function car(){}
car.prototype.msg_speed = "Está é a mensagem de Velocidade";
car.prototype.setSpeed = function(speed)
{
  this.speed = speed;
  alert("Velocidade alterada");
}

function Ferrari(){}
Ferrari.prototype = new car();
Ferrari.prototype.constructor = Ferrari;
Ferrari.prototype.setSpeed = function(speed)
{
  this.speed = speed;
  alert("Ferrari velocidade Alterada");
}

var ferrari1 = new Ferrari();
ferrari1.setSpeed(20);
alert("A velocidade é: " + ferrari1.speed);
