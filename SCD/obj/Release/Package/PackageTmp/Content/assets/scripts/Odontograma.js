var pieza=[];
var temp={};
var colorSelected="#989E26";
var id_enfermedad="4754";
var isEditing =false;
var id_paciente;
var enfermedades;
var id_odontograma;

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
   Get_pacientes_odontograma();
  
  inicio_odntograma();
});

function LoadEnfermedades(){
    var data={}
    $.ajax({            
        url: "Odontograma/get_enfermedades",
        type: 'POST',
        data: data,
        async: false,
        success:function(response){
            enfermedades=JSON.parse(response);
        } 
     }); 
}
function LoadComboEnfermedades(){
     var value='';
           if(enfermedades.length>0){
                $.each(enfermedades, function (i, item) {
                    value+='        <option value="'+item.id_enfermedad+'"><font style="vertical-align: inherit;">';
                    value+='            <font style="vertical-align: inherit;">'+item.nombre+'';
                    value+='        </font></font></option>';
                });
             }                            
    $('#cbo_enfermedades').html(value);
    colorSelected=enfermedades[0].color;
    id_enfermedad=enfermedades[0].id_enfermedad;
}

function inicio_odntograma(){
    LoadEnfermedades();
    LoadComboEnfermedades();
    //botones del grid
    $(document).on("click",".btn_guardar",function(){
        if(isEditing){
          UpdateOdontograma();
        }else{
          Generar_Odontograma_DB();  
        }
        

     });
    $(document).on("click",".Atras",function(){
        
        return_to_paciente();

     });
    $(document).on("click",".btn_add_odo",function(){
        id_paciente=$(this).attr('id');
        $('#pacientes').hide('slow');
        $('#odontograma').show('slow');
        generar_odontograma();

     });
    $(document).on("click",".btn_edit",function(){
        id_paciente=$(this).attr('id');
        
        $('#pacientes').hide('slow');
        $('#odontograma').show('slow');
        isEditing=true;
        get_all_parts_afected();
       //generar_odontograma_existente();

     });
    //controles del dinte
    $(document).on("click",".dt_top",function(){
        if(!isEditing){
             if($(this).hasClass('Edit')){
                $(this).removeClass('Edit');
                $(this).find('.txt_content').text("");
                $(this).css( "background-color","#FFFFFF");
             }else{
                $(this).addClass('Edit');
                $(this).find('.txt_content').text(id_enfermedad);
                $(this).css( "background-color",colorSelected);
             }
         }else{
            if($(this).hasClass('exist')){
                $(this).css( "background-color","#FFFFFF");
                $(this).addClass('borro');
             }else{
                if($(this).hasClass('Edit')){
                    $(this).removeClass('Edit');
                    $(this).find('.txt_content').text("");
                    $(this).css( "background-color","#FFFFFF");
                 }else{
                    $(this).addClass('Edit');
                    $(this).find('.txt_content').text(id_enfermedad);
                    $(this).css( "background-color",colorSelected);
                }
            }
         }
    });
    $(document).on("click",".dt_left",function(){
        if(!isEditing){
         if($(this).hasClass('Edit')){
            $(this).removeClass('Edit');
            $(this).find('.txt_content').text("");
            $(this).css( "background-color","#FFFFFF");
         }else{
            $(this).addClass('Edit');
            $(this).find('.txt_content').text(id_enfermedad);
            $(this).css( "background-color",colorSelected);
         }
        }else{
            if($(this).hasClass('exist')){
                $(this).css( "background-color","#FFFFFF");
                $(this).addClass('borro');
             }else{
               if($(this).hasClass('Edit')){
                    $(this).removeClass('Edit');
                    $(this).find('.txt_content').text("");
                    $(this).css( "background-color","#FFFFFF");
                }else{
                    $(this).addClass('Edit');
                    $(this).find('.txt_content').text(id_enfermedad);
                    $(this).css( "background-color",colorSelected);
         }
             }
         }
    });
    $(document).on("click",".dt_center",function(){
        if(!isEditing){

         if($(this).hasClass('Edit')){
            $(this).removeClass('Edit');
            $(this).find('.txt_content').text("");
            $(this).css( "background-color","#FFFFFF");
         }else{
            $(this).addClass('Edit');
            $(this).find('.txt_content').text(id_enfermedad);
            $(this).css( "background-color",colorSelected);
         }
         }else{
            if($(this).hasClass('exist')){
                $(this).css( "background-color","#FFFFFF");
                $(this).addClass('borro');
             }else{
                if($(this).hasClass('Edit')){
                    $(this).removeClass('Edit');
                    $(this).find('.txt_content').text("");
                    $(this).css( "background-color","#FFFFFF");
                }else{
                    $(this).addClass('Edit');
                    $(this).find('.txt_content').text(id_enfermedad);
                    $(this).css( "background-color",colorSelected);
                }
             }
         }
    });
    $(document).on("click",".dt_rigth",function(){
        if(!isEditing){
             if($(this).hasClass('Edit')){
                $(this).removeClass('Edit');
                $(this).find('.txt_content').text("");
                $(this).css( "background-color","#FFFFFF");
             }else{
                $(this).addClass('Edit');
                $(this).find('.txt_content').text(id_enfermedad);
                $(this).css( "background-color",colorSelected);
             }
        }else{
            if($(this).hasClass('exist')){
                $(this).css( "background-color","#FFFFFF");
                $(this).addClass('borro');
             }else{
               if($(this).hasClass('Edit')){
                $(this).removeClass('Edit');
                $(this).find('.txt_content').text("");
                $(this).css( "background-color","#FFFFFF");
             }else{
                $(this).addClass('Edit');
                $(this).find('.txt_content').text(id_enfermedad);
                $(this).css( "background-color",colorSelected);
             }
             }
        }
    });
    $(document).on("click",".dt_botom",function(){
        if(!isEditing){
             if($(this).hasClass('Edit')){
                $(this).removeClass('Edit');
                $(this).find('.txt_content').text("");
                $(this).css( "background-color","#FFFFFF");
             }else{
                $(this).addClass('Edit');
                $(this).find('.txt_content').text(id_enfermedad);
                $(this).css( "background-color",colorSelected);
             }
        }else{
            if($(this).hasClass('exist')){
                $(this).css( "background-color","#FFFFFF");
                $(this).addClass('borro');
             }else{
                $(this).addClass('Edit');
                $(this).find('.txt_content').text(id_enfermedad);
                $(this).css( "background-color",colorSelected);
             }
        }
    });

    $('#cbo_enfermedades').change(function() {
        var index= $('#cbo_enfermedades')[0].selectedIndex;
        colorSelected=enfermedades[index].color;
        id_enfermedad=enfermedades[index].id_enfermedad;
    });

   }

function generar_odontograma_existente(){
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
                            tabla+=get_diente(i,j);
                            tabla+='</td>';
                        }else{
                            tabla+='<td style="width: 13px;"></td>';
                        }
                        
                    }else
                    {
                        if ((j>=3&&j<=7)||(j>=9&&j<=13))
                        {
                           
                           tabla+='<td>';
                           tabla+=get_diente(i,j);
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

function generar_odontograma(){
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
                            tabla+=Diente('#FFFFFF','#FFFFFF','#FFFFFF','#FFFFFF','#FFFFFF',get_numero_pieza(i,j),"-","-","-","-","-");
                            tabla+='</td>';
                        }else{
                            tabla+='<td style="width: 13px;"></td>';
                        }
                        
                    }else
                    {
                        if ((j>=3&&j<=7)||(j>=9&&j<=13))
                        {
                           
                           tabla+='<td>';
                           tabla+=Diente('#FFFFFF','#FFFFFF','#FFFFFF','#FFFFFF','#FFFFFF',get_numero_pieza(i,j),"-","-","-","-","-","","","","","");
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
function get_all_parts_afected(){

    var data = {};
        data.id_paciente=id_paciente;
    $.ajax({
        type: "POST",
        url: "Odontograma/Search_Pieza",
        data: data,
        async: false,
        datatype: "JSON",
        success: function (response) {
            all_parts_afected=JSON.parse(response);
            generar_odontograma_existente();
        }
    });
}

function get_diente(i,j){

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
       
       
  
   return Diente(colortop,colorr,colorl,colorb,colorc,numero,enfer_idt,enfer_idl,enfer_idr,enfer_idb,enfer_idc,existt,existr,existl,existc,existb);;
}
function get_numero_pieza(i,j){
        for (var f = 0; f < pieza.length; f++) {
          
            if(pieza[f].i==i && pieza[f].j==j){
                return pieza[f].numeroPieza;
            }
        }
}

function principal() {
   window.location = "principal";
}
    
function Get_pacientes_odontograma() {
    var data = {};
   
    $.ajax({
        type: "POST",
        url: "Odontograma/Get_Paciente",
        data: data,
        datatype: "JSON",
        success: function (response) {

            //$('#tablepacientes').empty();
            var resp = JSON.parse(response);
            var tabla;
            tabla='<tbody>';
            $.each(resp, function (i, item) {
                
                var as="";
                if(item.estado==1){
                    as+="<button type='button' id="+item.id_paciente+"  class='btn btn-success btn_add_odo'><i class='fa fa-check-circle'></i>";
                    as+="        <span>Agregar</span>"
                    as+="</button>";
                }else{
                    as+="<button type='button' value="+item.id_paciente+" disabled class='btn btn-success btn_add_odo'><i class='fa fa-check-circle'></i>";
                    as+="        <span>Agregar</span>"
                    as+="</button>";
                }
               // cols += "  <td>" + as + "</td>";

                var btn_edit="";
                    btn_edit+="<button type='button' id="+item.id_paciente+"  class='btn btn-warning btn_edit'><i class='fa fa-check-circle'></i>";
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
            $('#tablepacientes').html(tabla);
        }
       
    });
}
//#FFFFFF

function Diente(color_top,color_rigth,color_left,color_botom,color_center,numero,id_enfermedad_top,id_enfermedad_left,id_enfermedad_rigth,id_enfermedad_botom,id_enfermedad_center,classEt,classEr,classEl,classc,classEb){
    var value='           <div style="width: 50px; text-align: center;">';
        value+='                   <label class="txt_numero">'+numero+'</label>';
        value+='             <div class="circle-tile-content ">';

        value+='                   <div id="'+numero+'-1" value="'+id_enfermedad_top+'" class="parte-tile1 dt_top '+classEt+'" style="background-color: '+color_top+'; height: 12px; " >';
       
        value+='                        <label class="txt_content" hidden>'+id_enfermedad_top+'</label>';
        value+='                   </div>';
        value+='                   <div class="row">';

        value+='                        <table style="margin-left: 15px;">';
        value+='                            <tr>';
        value+='                                <td>';
        value+='                                   <div id="'+numero+'-3" value="'+id_enfermedad_left+'" class="parte-tile1 dt_left '+classEl+'" style="background-color: '+color_left+'; height: 30px; width: 12px;  margin-left: 0px;" >';
       
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_left+'</label>';
        value+='                                   </div>';
        value+='                                </td>';
        value+='                                <td>';
        value+='                                   <div id="'+numero+'-2" value="'+id_enfermedad_center+'" class="parte-tile1 dt_center '+classc+'" style="background-color: '+color_center+'; height: 30px; width: 20px; border-radius: 100px;margin-left: 0px;" >';
        
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_center+'</label>';
        value+='                                   </div>';
        value+='                                 </td>';
        value+='                                 <td>';
        value+='                                    <div id="'+numero+'-7" value="'+id_enfermedad_rigth+'" class="parte-tile1 dt_rigth '+classEr+'" style="background-color: '+color_rigth+'; height: 30px; width: 15px; ; margin-left: 0px;" >';
       
        value+='                                        <label class="txt_content" hidden>'+id_enfermedad_rigth+'</label>';
        value+='                                   </div>';
        value+='                                 </td>';
        value+='                             </tr>';
        value+='                         </table>';
                        
        value+='                   </div>';
        value+='                   <div id="'+numero+'-4" value="'+id_enfermedad_botom+'" class="parte-tile1 dt_botom '+classEb+'"  style="background-color: '+color_botom+'; height: 12px; " >';
        
        value+='                        <label class="txt_content" hidden>'+id_enfermedad_botom+'</label>';
        value+='                    </div>';                        
        value+='              </div>';
        value+='           </div>';
      
    return value;
}
function Generar_Odontograma_DB(){
    var result;
    var data = {};
        data.id_paciente=id_paciente;
    $.ajax({
        type: "POST",
        url: "Odontograma/Generar_odontograma",
        data: data,
        async: false,
        datatype: "JSON",
        success: function (response) {
            result=response;  
        }
       
    });
    if(result!="ERROR"){
      id_odontograma=result;
      Generar_Odontograma_Detalle();
    }
}
function Generar_Odontograma_Detalle(){
    var Inserts="";
    var cont=0;
    var editLength=$(".Edit").length;

     $(".Edit").each(function() {
        
        if(cont>=1&&cont<=editLength){
            Inserts+=',';
        }
        var id_enfer=$(this).find('.txt_content').text();
        var temp=$(this).attr('id');
        Inserts+=temp+'-'+id_enfer;
        cont++;
       //insert_existent_Odonto_Detail(id[0],id[1],id_enfer);
    });

    if(Inserts.length>0){
       insert_existent_Odonto_Detail(Inserts);
    }
    return_to_paciente();
    $('#modal-success').modal("show");
    
}

function UpdateOdontograma(){
    //=================================
    var Inserts="";
    var cont=0;
    var editLength=$(".Edit").length;
    //==============================
    var Delets="";
    var contdelets=0;
    var deleteLength=$(".borro").length;
    //=========================
    $(".borro").each(function() {
        if(contdelets>=1&&contdelets<=deleteLength){
            Delets+=',';
        }
        var temp=$(this).attr('id');
        var id=temp.split("-");
        Delets+=temp;
        contdelets++;
       //update_exist_odonto_detail(id[0],id[1]);

    });
    //=====================================
    $(".Edit").each(function() {
        
        if(cont>=1&&cont<=editLength){
            Inserts+=',';
        }
        var id_enfer=$(this).find('.txt_content').text();
        var temp=$(this).attr('id');
        Inserts+=temp+'-'+id_enfer;
        cont++;
       //insert_existent_Odonto_Detail(id[0],id[1],id_enfer);
    });

    if(Inserts.length>0){
       insert_existent_Odonto_Detail(Inserts);
    }
   if(Delets.length>0){
       update_exist_odonto_detail(Delets);
   }

   $('#modal-success').modal("show");
    return_to_paciente();

}
function insert_existent_Odonto_Detail(valor){
    var result;
    var data = {};
        data.id_odontograma=id_paciente;
        data.value=valor;
    $.ajax({
        type: "POST",
        async: true,
        url: "Odontograma/Generar_odontograma_Detalle",
        data: data,
        datatype: "JSON",
        success: function (response) {
            result=response;
        }
       
    });
    if(result=="OK"){
     
   }
       
}
function update_exist_odonto_detail(valor){
    var result;
    var data = {};
        data.value=valor;
       
    $.ajax({
        type: "POST",
        url: "Odontograma/Update_odontograma_Detalle",
        data: data,
        async: true,
        datatype: "JSON",
        success: function (response) {
            result=response;
        }
       
    });
    if(result=="OK"){
     
    
   }
    
}

function return_to_paciente(){
    id_paciente="";
    $('#odontograma').hide('slow');
    $('#pacientes').show('slow');
    
}