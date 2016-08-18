function LoadXMLDoc()
{
  var xmlhttp = new XMLHttpRequest();
  /*Evento quando mudar o estado fo XMLHttpRequest*/
  xmlhttp.onreadystatechange = function()
  {
    /*4 - resposta está pronta e stauts 200: OK*/
    if(xmlhttp.readyState == 4 && xmlhttp.status == 200)
    {
      document.getElementById("dv_01").innerHTML = xmlhttp.responseText;
    }
  }
  /*Abrir conexão,Get - pegar, Nome do arquivo*/
  xmlhttp.open("GET", "ajax_teste.txt", true);
  xmlhttp.send(); /*Envia a requisição*/
}
