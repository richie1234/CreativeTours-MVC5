$(document).ready(function () {
    $('#data2 tbody tr:even').css('background-color', 'burlywood');

    $('#data3 tbody tr:even').css('background-color', 'burlywood');


    $("tr").not(':first').hover(
  function () {
      $(this).css("background", "green");
     
     
  },
  function () {
      $(this).css("background", "");
      $('#data2 tbody tr:even').css('background-color', 'burlywood');
      $('#data3 tbody tr:even').css('background-color', 'burlywood');
  }
);

});



$(function() {
    $( "#accordion" ).accordion();
});

$(function () {
    $("#tabs").tabs();
});


  $(function() {
      $("#reviewDate").datepicker({
          dateFormat: "dd/mm/yy"
      });
  });


  $(function () {
      $("#visitedDate").datepicker({
          dateFormat: "dd/mm/yy"
      });
  });



