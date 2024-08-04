<?php
use app\Http\Controllers\LiveTable;
use app\Http\Controllers\Controller;
use Illuminate\Http\Request;
?>
<!DOCTYPE html>
<html lang="en">
 <head>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <title>Saját járművek</title>
  
</head>
 <body style="color: yellow;background-color: #404040">
  <br />
  <div class="container box" style="border-color: black">
   <div class="panel panel-default">
    <div class="panel-heading" style="color: yellow;background-color:#505050">Saját járműveim</div>
    <div class="panel-body" style="color: yellow;background-color:#606060">
     <div id="message"></div>
     <div class="table-responsive">
      <table class="table table-striped table-bordered">
       <thead>
        <tr>  
         <th>Jármű típusa *</th>
         <th>Jármű márkája</th>
         <th>Rendszámtábla</th>
         <th>Az eddig megtett km *</th>
         <th>Minősége (0/5) *</th>
         <th>Fénykép</th>
         <th>Törlés</th>
        </tr>
       </thead>
       <tbody>
       
       </tbody>
      </table>
      {{ csrf_field() }}
     </div>
    </div>
   </div>
  </div>
 </body>
</html>



<script>
$(document).ready(function(){

 fetch_data();

 function fetch_data()
 {
  $.ajax({
   url: "/livetable/fetch_data"  ,
   dataType:"json",
   success:function(data)
   {
    var html = '';
    html += '<tr>';
    html += '<td contenteditable id="vehicle_type"></td>';
    html += '<td contenteditable id="vehicle_brand"></td>';
    html += '<td contenteditable id="license_plate"></td>';
    html += '<td contenteditable id="km"></td>';
    html += '<td contenteditable id="quality"></td>';
    html += '<td contenteditable id="picture"></td>';
    html += '<td><button type="button" class="btn btn-success btn-xs" id="add">Hozzáadás</button></td></tr>';

    for(var count=0; count < data.length; count++)
    {
     html +='<tr>';
     html +='<td contenteditable class="column_name" data-column_name="vehicle_type" data-id="'+data[count].id+'">'+data[count].vehicle_type+'</td>';
     html += '<td contenteditable class="column_name" data-column_name="vehicle_brand" data-id="'+data[count].id+'">'+data[count].vehicle_brand+'</td>';
     html +='<td contenteditable class="column_name" data-column_name="license_plate" data-id="'+data[count].id+'">'+data[count].license_plate+'</td>';
     html +='<td contenteditable class="column_name" data-column_name="km" data-id="'+data[count].id+'">'+data[count].km+'</td>';
     html +='<td contenteditable class="column_name" data-column_name="quality" data-id="'+data[count].id+'">'+data[count].quality+'</td>';
     html +='<td contenteditable class="column_name" data-column_name="picture" data-id="'+data[count].id+'">'+data[count].picture+'</td>';
     html += '<td><button type="button" class="btn btn-danger btn-xs delete" id="'+data[count].id+'">Törlés</button></td></tr>';
    }
    $('tbody').html(html);
   }
  });
 }

 var _token = $('input[name="_token"]').val();

 $(document).on('click', '#add', function(){
  var vehicle_type = $('#vehicle_type').text();
  var vehicle_brand = $('#vehicle_brand').text();
  var license_plate = $('#license_plate').text();
  var km = $('#km').text();
  var quality = $('#quality').text();
  var picture = $('#picture').text();

  if(vehicle_type != '' && km != '' && quality !='')
  {
   $.ajax({
    url:route('livetable.add_data')  ,
    method:"POST",
    data:{vehicle_type:vehicle_type, km:km, quality:quality, _token:_token},
    success:function(data)
    {
     $('#message').html(data);
     fetch_data();
    }
   });
  }
  else
  {
   $('#message').html("<div class='alert alert-danger'>Fontos információkat ki kell tölteni</div>");
  }
 });

 $(document).on('blur', '.column_name', function(){
  var column_name = $(this).data("column_name");
  var column_value = $(this).text();
  var id = $(this).data("id");
  
  if(column_value != '')
  {
   $.ajax({
    url:route('livetable.update_data')  ,
    method:"POST",
    data:{column_name:column_name, column_value:column_value, id:id, _token:_token},
    success:function(data)
    {
     $('#message').html(data);
    }
   })
  }
  else
  {
   $('#message').html("<div class='alert alert-danger'>Írd be az adatokat!</div>");
  }
 });

 $(document).on('click', '.delete', function(){
  var id = $(this).attr("id");
  if(confirm("Biztosan törölni szeretnéd?"))
  {
   $.ajax({
    url: route('livetable.delete_data')  ,
    method:"POST",
    data:{id:id, _token:_token},
    success:function(data)
    {
     $('#message').html(data);
     fetch_data();
    }
   });
  }
 });


});
</script>
