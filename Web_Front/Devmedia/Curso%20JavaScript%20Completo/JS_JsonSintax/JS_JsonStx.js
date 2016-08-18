var carros =
[
  {"Montadora" : "VM", "Modelo" : "Golf"},
  {"Montadora" : "Porcshe", "Modelo" : "911"},
  {"Montadora" : "Ferrari", "Modelo" : "F50"},
  {"Montadora" : "Audi", "Modelo" : "A8"}
];

document.getElementById("jcarroVelho").innerHTML = carros[3].Montadora + " " + carros[3].Modelo;

carros[3].Montadora = "BMW";
carros[3].Modelo = "540I";

document.getElementById("jcarroNovo").innerHTML = carros[3].Montadora + " " + carros[3].Modelo;
