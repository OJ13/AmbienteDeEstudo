$(document).ready(function()
{
  $("#btn_FadeIn").click(function()
  {
    $("#dv_01").fadeIn();
    $("#dv_02").fadeIn("slow");
    $("#dv_03").fadeIn(3000);
  });

  $("#btn_FadeOut").click(function()
  {
    $("#dv_01").fadeOut();
    $("#dv_02").fadeOut("slow");
    $("#dv_03").fadeOut(3000);
  });

});
