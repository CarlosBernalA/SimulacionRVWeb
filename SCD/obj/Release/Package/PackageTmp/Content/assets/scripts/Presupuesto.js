var Tratamientos_add="";
var tratamientos_array=[];
var temp={};
var colorSelected="#989E26";
var id_enfermedad="4754";
var isEditing =false;
var id_paciente=1;
var tratamientos;
var id_presupuesto;
var contadoradd=0;
var citas=[];
var contadoraci=0;
$(document).ready(function () {

            temp= { i: 0, j: 0, numeroPieza: 18 };
            pieza.push(temp);
            temp={ i: 0, j: 1, numeroPieza: 17 };
            pieza.push(temp);
            temp={ i: 0, j: 2, numeroPieza: 16 };
            pieza.push(temp);
            temp={ i: 0, j: 3, numeroPieza: 15 };
            pieza.push(temp);
            temp={ i: 0, j: 4, numeroPieza: 14 };
            pieza.push(temp);
            temp={ i: 0, j: 5, numeroPieza: 13 };
            pieza.push(temp);
            temp={ i: 0, j: 6, numeroPieza: 12 };
            pieza.push(temp);
            temp={ i: 0, j: 7, numeroPieza: 11 };
            pieza.push(temp);

            temp={ i: 0, j: 9, numeroPieza: 21 };
            pieza.push(temp);
            temp={ i: 0, j: 10, numeroPieza: 22 };
            pieza.push(temp);
            temp={ i: 0, j: 11, numeroPieza: 23 };
            pieza.push(temp);
            temp={ i: 0, j: 12, numeroPieza: 24 };
            pieza.push(temp);
            temp={ i: 0, j: 13, numeroPieza: 25 };
            pieza.push(temp);
            temp={ i: 0, j: 14, numeroPieza: 26 };
            pieza.push(temp);
            temp={ i: 0, j: 15, numeroPieza: 27 };
            pieza.push(temp);
            temp={ i: 0, j: 16, numeroPieza: 28 };
            pieza.push(temp);

            temp={ i: 1, j: 3, numeroPieza: 55 };
            pieza.push(temp);
            temp={ i: 1, j: 4, numeroPieza: 54 };
            pieza.push(temp);
            temp={ i: 1, j: 5, numeroPieza: 53 };
            pieza.push(temp);
            temp={ i: 1, j: 6, numeroPieza: 52 };
            pieza.push(temp);
            temp={ i: 1, j: 7, numeroPieza: 52 };
            pieza.push(temp);

            temp={ i: 1, j: 9, numeroPieza: 61 };
            pieza.push(temp);
            temp={ i: 1, j: 10, numeroPieza: 62 };
            pieza.push(temp);
            temp={ i: 1, j: 11, numeroPieza: 63 };
            pieza.push(temp);
            temp={ i: 1, j: 12, numeroPieza: 64 };
            pieza.push(temp);
            temp={ i: 1, j: 13, numeroPieza: 65 };
            pieza.push(temp);

            temp={ i: 2, j: 3, numeroPieza: 85 };
            pieza.push(temp);
            temp={ i: 2, j: 4, numeroPieza: 84 };
            pieza.push(temp);
            temp={ i: 2, j: 5, numeroPieza: 83 };
            pieza.push(temp);
            temp={ i: 2, j: 6, numeroPieza: 82 };
            pieza.push(temp);
            temp={ i: 2, j: 7, numeroPieza: 81 };
            pieza.push(temp);

            temp={ i: 2, j: 9, numeroPieza: 71 };
            pieza.push(temp);
            temp={ i: 2, j: 10, numeroPieza: 72 };
            pieza.push(temp);
            temp={ i: 2, j: 11, numeroPieza: 73 };
            pieza.push(temp);
            temp={ i: 2, j: 12, numeroPieza: 74 };
            pieza.push(temp);
            temp={ i: 2, j: 13, numeroPieza: 75 };
            pieza.push(temp);


            temp={ i: 3, j: 0, numeroPieza: 48 };
            pieza.push(temp);
            temp={ i: 3, j: 1, numeroPieza: 47 };
            pieza.push(temp);
            temp={ i: 3, j: 2, numeroPieza: 46 };
            pieza.push(temp);
            temp={ i: 3, j: 3, numeroPieza: 45 };
            pieza.push(temp);
            temp={ i: 3, j: 4, numeroPieza: 44 };
            pieza.push(temp);
            temp={ i: 3, j: 5, numeroPieza: 43 };
            pieza.push(temp);
            temp={ i: 3, j: 6, numeroPieza: 42 };
            pieza.push(temp);
            temp={ i: 3, j: 7, numeroPieza: 41 };
            pieza.push(temp);

            temp={ i: 3, j: 9, numeroPieza: 31 };
            pieza.push(temp);
            temp={ i: 3, j: 10, numeroPieza: 32 };
            pieza.push(temp);
            temp={ i: 3, j: 11, numeroPieza: 33 };
            pieza.push(temp);
            temp={ i: 3, j: 12, numeroPieza: 34 };
            pieza.push(temp);
            temp={ i: 3, j: 13, numeroPieza: 35 };
            pieza.push(temp);
            temp={ i: 3, j: 14, numeroPieza: 36 };
            pieza.push(temp);
            temp={ i: 3, j: 15, numeroPieza: 37 };
            pieza.push(temp);
            temp={ i: 3, j: 16, numeroPieza: 38 };
            pieza.push(temp);
  // Get_pacientes();
  
  inicio();
});
function inicio(){
      Get_pacientes();
      LoadTramientos();
      LoadComboTramientos();

     $(document).on("click",".btn_add_pre",function(){
        id_paciente=$(this).attr('id');
        $('#pacientes_pre').hide('slow');
        $('#presupuestos').hide('slow');
        $('#presupuesto').show('slow');
        get_all_parts_afected_samall();

     });
     $(document).on("click",".retornar",function(){
        id_paciente=$(this).attr('id');
        $('#pacientes_pre').show('slow');
        $('#presupuestos').hide('slow');
        $('#presupuesto').hide('slow');
        get_all_parts_afected_samall();

     });
    $(document).on("click",".btn_edit_tra",function(){
        id_paciente=$(this).attr('id');
        $('#pacientes_pre').hide('slow');
        $('#presupuesto').hide('slow');
        $('#presupuestos').show('slow');
        
        Get_presupuestos();
        //get_all_parts_afected_samall();
       //generar_odontograma_existente_samall();

     });
    $(document).on("click",".btn_edit_pre",function(){
        id_presupuesto=$(this).attr('id');
        
        $('#pacientes_pre').hide('slow');
        $('#presupuesto').show('slow');
        $('#presupuestos').hide('slow');
        isEditing=true;
        Get_presupuestos();
        get_all_parts_afected_samall();
        //get_all_parts_afected_samall();
       //generar_odontograma_existente_samall();

     });

    $(document).on("click",".remove_row",function(){
      var id=$(this).attr('id');
       $(this).closest('tr').remove();
        remove_array(id);
        
        //get_all_parts_afected_samall();
       //generar_odontograma_existente_samall();

     });
    $('#btn_add').click(function () {
        add_tratamiento();
    });
    $('#btn_remove').click(function () {
        var index = $('#table-tratamientos').closest("tr").index();
        remove_array();
    });
    $('#btn_add_cita').click(function () {
        //traer_pago_pacientes();
    });
    $('#btn_save').click(function () {
         guardar_All();
    });

    $('#btn_add_cita').click(function () {
         $('#modal-success').modal('show');
    });
    $('.btn_agregar').click(function () {
         agregarCita();
    });
    $('.remove_row_cita').click(function () {
            var id=$(this).attr('id');
            $(this).closest('tr').remove();
            removeCita(id);
    });
    $('.btn_cencelar').click(function () {
            citas=[];
            contadoraci=0;
            $("#tablepacientes_citas tr").remove(); 

    });

    
          
                 /*-----------------------------------/
                  /*    DATE PICKER
                  /*----------------------------------*/
                  $('.inline-datepicker').datepicker(
                  {
                        todayHighlight: true
                  });
                  /*-----------------------------------/
                  /*    COLOR PICKER
                  /*----------------------------------*/
                  $('#demo-colorpicker1').colorpicker(
                  {
                        align: 'left'
                  });
                  $('#demo-colorpicker2').colorpicker(
                  {
                        align: 'left',
                        format: 'rgba'
                  });
                  $('#demo-colorpicker3').colorpicker();
                  $('#demo-colorpicker4').colorpicker(
                  {
                        colorSelectors:
                        {
                              '#000000': '#000000',
                              '#00AAFF': '#00AAFF',
                              '#41B314': '#41B314',
                              '#e4cb10': '#e4cb10',
                              '#F9354C': '#F9354C',
                              '#5bc0de': '#5bc0de',
                              '#777777': '#777777'
                        }
                  });
                  $('#colorpicker-inline').colorpicker(
                  {
                        color: '#41B314',
                        container: true,
                        inline: true
                  });
                  $('#demo-colorpicker5').colorpicker().on('changeColor', function(e)
                  {
                        $('#demo-colorpicker5').css('background-color', e.color.toString('rgba'));
                  });
                  /*-----------------------------------/
                  /*    BOOTSTRAP CLOCK PICKER
                  /*----------------------------------*/
                  $('.basic-clockpicker').clockpicker(
                  {
                        donetext: 'DONE',
                  });
                  var input = $('#single-input').clockpicker(
                  {
                        placement: 'top',
                        autoclose: true,
                        'default': 'now'
                  });
                  $('#check-minutes').click(function(e)
                  {
                        // Have to stop propagation here
                        e.stopPropagation();
                        input.clockpicker('show').clockpicker('toggleView', 'minutes');
                  });    
      
}
function agregarCita(){
      var date =$('#txt_date').val();
      var time=$('#txt_time').val();
      var newRow = $("<tr>");
          var cols = "";
          cols += "  <td>" + date + "</td>";
          cols += "  <td>" + time+ "</td>";
          var btn='<button id="'+(date+'-'+time+'-'+contadoraci)+'" style="margin-left: 35px; margin-bottom: 10px;" type="button" class="btn btn-primary active remove_row_cita">';
              btn+='        <i class="fa fa-trash-o"></i>';
              
              btn+='</button>';
          cols+="  <td>" + btn+ "</td>";
          newRow.append(cols);
          $("#tablepacientes_citas").append(newRow);

          citas.push(date+'-'+time+'-'+contadoraci);
          contadoraci++; 
}
function removeCita(value){
      var index = citas.indexOf(value);
      
      
      if (index > -1) {
        citas.splice(index, 1);
      }
    
     
}
function get_Date(value){
    var dateString = value.substr(6);
    var currentTime = new Date(parseInt(dateString ));
    var month = currentTime.getMonth() + 1;
    var day = currentTime.getDate();
    var year = currentTime.getFullYear();
    var date = day + "/" + month + "/" + year;
return date;
}
function LoadTramientos(){
    var data={}
    $.ajax({            
        url: "Presupuesto/Get_Tratamientos",
        type: 'POST',
        data: data,
        async: false,
        success:function(response){
            tratamientos=JSON.parse(response);
        } 
     }); 
}

function LoadComboTramientos(){
     var value='';
           if(tratamientos.length>0){
                $.each(tratamientos, function (i, item) {
                    value+='        <option value="'+item.id_tratamiento+'"><font style="vertical-align: inherit;">';
                    value+='            <font style="vertical-align: inherit;">'+item.nombre+'';
                    value+='        </font></font></option>';
                });
             }                            
    $('#cbo_tratamientos').html(value);
    
}
function add_tratamiento(){
      var index= $('#cbo_tratamientos')[0].selectedIndex;

      var newRow = $("<tr>");
          var cols = "";
          cols += "  <td>" + tratamientos[index].nombre + "</td>";
          cols += "  <td>" + tratamientos[index].costo + "</td>";
          var btn='<button id="'+(tratamientos[index].id_tratamiento+'-'+'1'+'-'+contadoradd)+'" style="margin-left: 35px; margin-bottom: 10px;" type="button" class="btn btn-primary active remove_row">';
              btn+='        <i class="fa fa-trash-o"></i>';
              
              btn+='</button>';
          cols+="  <td>" + btn+ "</td>";
          newRow.append(cols);
          $("#table-tratamientos").append(newRow);

          tratamientos_array.push(tratamientos[index].id_tratamiento+'-'+'1'+'-'+contadoradd);
          contadoradd++;

}
function remove_array(value){
      //var array = [2, 5, 9];
      var index = tratamientos_array.indexOf(value);
      console.log(tratamientos_array);
      
      if (index > -1) {
        tratamientos_array.splice(index, 1);
      }
      console.log(tratamientos_array);
     
}
function Generar_Presupuesto(){
    var result;
    var data = {};
        data.id_paciente=id_paciente;
        data.id_colaborador=1;
    $.ajax({
        type: "POST",
        url: "Presupuesto/Seve_Presupuesto",
        data: data,
        async: false,
        datatype: "JSON",
        success: function (response) {
            result=response;  
        }
       
    });
    if(result!="ERROR"){
      id_presupuesto=result;
      generarPresupuesto_detail();
      guardarCitas();
      $('#pacientes_pre').show('slow');
      $('#presupuestos').hide('slow');
      $('#presupuesto').hide('slow');
      $('#myModal').modal("show");
    }else{
      alert("error");
    }
      
}
function generarPresupuesto_detail(){
      var value="";
      var tope=tratamientos_array.length;
      for (var i = 0; i < tope; i++) {
            if(i>=1&&i<=tope){
                  value+=",";
            }

            value+=tratamientos_array[i];
      }

      if(value.length>0){
        var data = {};
        data.id_presupuesto=id_presupuesto;
        data.value=value;
          $.ajax({
              type: "POST",
              url: "Presupuesto/Seve_presupuesto_detail",
              data: data,
              async: true,
              datatype: "JSON",
              success: function (response) {
                   
              }
             
          });
      }
}
function guardarCitas(){
   var value="";
      var tope=citas.length;
      for (var i = 0; i < tope; i++) {
            if(i>=1&&i<=tope){
                  value+=",";
            }

            value+=citas[i];
      }

      if(value.length>0){
        var data = {};
        data.id_presupuesto=id_presupuesto;
        data.value=value;
          $.ajax({
              type: "POST",
              url: "Presupuesto/Seve_Citas",
              data: data,
              async: true,
              datatype: "JSON",
              success: function (response) {
                  
              }
             
          });
      }   
}
function guardar_All(){
      if(isEditing){
            generarPresupuesto_detail();
            guardarCitas();
            $('#myModal').modal("show");
      }else{
            Generar_Presupuesto();
      }

}
function Get_pacientes() {
    var data = {};
   
    $.ajax({
        type: "POST",
        url: "Presupuesto/Get_Paciente",
        data: data,
        datatype: "JSON",
        success: function (response) {

            //$('#tablepacientes').empty();
            var resp = JSON.parse(response);
            var tabla;
            tabla='<tbody>';
            $.each(resp, function (i, item) {
                
                var as="";
                    as+="<button type='button' id="+item.id_paciente+"  class='btn btn-success btn_add_pre'><i class='fa fa-check-circle'></i>";
                    as+="        <span>Agregar</span>"
                    as+="</button>";
               
               // cols += "  <td>" + as + "</td>";

                var btn_edit="";
                    btn_edit+="<button type='button' id="+item.id_paciente+"  class='btn btn-warning btn_edit_tra'><i class='fa fa-check-circle'></i>";
                    btn_edit+="        <span>Editar</span>"
                    btn_edit+="</button>";
                
                    tabla+=' <tr>';
                    tabla+='<td >'+item.nombre+'</td>'; 
                    tabla+='<td >'+item.apellido+'</td>'; 
                    tabla+='<td >'+item.dni+'</td>'; 
                    tabla+='<td >'+item.telefono +'</td>'; 
                    tabla += "<td>" + as + "</td>";
                    tabla += "<td>" + btn_edit + "</td>"; 
                    tabla+=' </tr>';

    

            });
            tabla+='</tbody>';
            $('#tablepacientes_pre').html(tabla);
        }
       
    });
}
function Get_presupuestos() {
    var data = {};
        data.id_paciente=id_paciente;
    $.ajax({
        type: "POST",
        url: "Presupuesto/Get_Presupuestos",
        data: data,
        datatype: "JSON",
        success: function (response) {

            //$('#tablepacientes').empty();
            var resp = JSON.parse(response);
            var tabla;
            tabla='<tbody>';
            $.each(resp, function (i, item) {
                
                
               // cols += "  <td>" + as + "</td>";

                var btn_edit="";
                    btn_edit+="<button type='button' id="+item.id_presupuesto+"  class='btn btn-warning btn_edit_pre'><i class='fa fa-check-circle'></i>";
                    btn_edit+="        <span>Editar</span>"
                    btn_edit+="</button>";
                
                    tabla+=' <tr>';
                    tabla+='<td >'+get_Date(item.fecha)+'</td>'; 
                    tabla += "<td>" + btn_edit + "</td>"; 
                    tabla+=' </tr>';

    

            });
            tabla+='</tbody>';
            $('#tablepresupuestos').html(tabla);
        }
       
    });
}

function get_all_parts_afected_samall(){

    var data = {};
        data.id_paciente=id_paciente;
    $.ajax({
        type: "POST",
        url: "Presupuesto/Search_Pieza",
        data: data,
        async: false,
        datatype: "JSON",
        success: function (response) {
            all_parts_afected=JSON.parse(response);
            generar_odontograma_existente_samall();
        }
    });
}

function generar_odontograma_existente_samall(){
     var tabla='<tbody>';
     for (var i = 0; i < 4; i++)
            {
                tabla+='<tr>';
                for (var j = 0; j < 17; j++)
                {
                    if (i==0||i==3)
                    {
                        if (j!=8)
                        {
                            tabla+='<td>';
                            tabla+=get_diente_samall(i,j);
                            tabla+='</td>';
                        }else{
                            tabla+='<td style="width: 13px;"></td>';
                        }
                        
                    }else
                    {
                        if ((j>=3&&j<=7)||(j>=9&&j<=13))
                        {
                           
                           tabla+='<td>';
                           tabla+=get_diente_samall(i,j);
                           tabla+='</td>';
                        }else{
                            tabla+='<td></td>';
                        }
                    }
                }
               tabla+='</tr>';
            }
            $('#tabla_odontograma').html(tabla); 
}
function get_diente_samall(i,j){

    var colortop='#FFFFFF',colorr='#FFFFFF',colorl='#FFFFFF',colorc='#FFFFFF',colorb='#FFFFFF';
    var enfer_idt="-",enfer_idr="-",enfer_idl="-",enfer_idb="-",enfer_idc="-";
    var existt="",existr="",existl="",existc="",existb="";
    var numero=get_numero_pieza(i,j);
       
            
        $.each(all_parts_afected, function (i, item) {
            //alert(id_paciente);
           if(item.numero==numero){
               if(item.id_partediente=="1"){
                    colortop=item.color;
                    enfer_idt=item.id_enfermedad;
                    existt="exist";
               }else if(item.id_partediente=="2"){
                    colorc=item.color;
                    enfer_idc=item.id_enfermedad;
                    existc="exist";

               }else if(item.id_partediente=="3"){
                    colorl=item.color;
                    enfer_idl=item.id_enfermedad;
                    existl="exist";
                
               }else if(item.id_partediente=="4"){
                    colorb=item.color;
                    enfer_idb=item.id_enfermedad;
                    existb="exist";
                
               }else if(item.id_partediente=="7"){
                    colorr=item.color;
                    enfer_idr=item.id_enfermedad;
                    existr="exist";
               } 
           } 
           
           
        }); 
       
       
  
   return Diente_small(colortop,colorr,colorl,colorb,colorc,numero,enfer_idt,enfer_idl,enfer_idr,enfer_idb,enfer_idc,existt,existr,existl,existc,existb);;
}
function Diente_small(color_top,color_rigth,color_left,color_botom,color_center,numero,id_enfermedad_top,id_enfermedad_left,id_enfermedad_rigth,id_enfermedad_botom,id_enfermedad_center,classEt,classEr,classEl,classc,classEb){
    var value='           <div style="width: 39px; text-align: center;">';
        value+='                   <label class="txt_numero">'+numero+'</label>';
        value+='             <div class="circle-tile-content-small ">';

        value+='                   <div id="'+numero+'-1" value="'+id_enfermedad_top+'" class="parte-tile1 dt_top '+classEt+'" style="background-color: '+color_top+'; height: 10px; " >';
       
        value+='                        <label class="txt_content" hidden>'+id_enfermedad_top+'</label>';
        value+='                   </div>';
        value+='                   <div class="row">';

        value+='                        <table style="margin-left: 15px;">';
        value+='                            <tr>';
        value+='                                <td>';
        value+='                                   <div id="'+numero+'-3" value="'+id_enfermedad_left+'" class="parte-tile1 dt_left '+classEl+'" style="background-color: '+color_left+'; height: 22px; width: 9px;  margin-left: 0px;" >';
       
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_left+'</label>';
        value+='                                   </div>';
        value+='                                </td>';
        value+='                                <td>';
        value+='                                   <div id="'+numero+'-2" value="'+id_enfermedad_center+'" class="parte-tile1 dt_center '+classc+'" style="background-color: '+color_center+'; height: 22px; width: 20px; border-radius: 100px;margin-left: 0px;" >';
        
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_center+'</label>';
        value+='                                   </div>';
        value+='                                 </td>';
        value+='                                 <td>';
        value+='                                    <div id="'+numero+'-7" value="'+id_enfermedad_rigth+'" class="parte-tile1 dt_rigth '+classEr+'" style="background-color: '+color_rigth+'; height: 22px; width: 9px; ; margin-left: 0px;" >';
       
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_rigth+'</label>';
        value+='                                   </div>';
        value+='                                 </td>';
        value+='                             </tr>';
        value+='                         </table>';
                        
        value+='                   </div>';
        value+='                   <div id="'+numero+'-4" value="'+id_enfermedad_botom+'" class="parte-tile1 dt_botom '+classEb+'"  style="background-color: '+color_botom+'; height: 10px; " >';
        
        value+='                        <label class="txt_content" hidden>'+id_enfermedad_botom+'</label>';
        value+='                    </div>';                        
        value+='              </div>';
        value+='           </div>';
      
    return value;
}

