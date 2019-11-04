
var _data={};
var id_paciente;
var isEditing = false;
var maikol={
    nombre: "maikol",
    apellido:"salazar"
}
var maik = [{
    nombre: "maikol",
    apellido:"salazar"
},
{
    nombre: "gringo",
    apellido: "lesly",
    dni:"8934768"
}];
console.log(maik[0].nombre);
console.log(maik[1].dni);
console.log(maikol.nombre);

$(document).ready(function () {
    Inicio();
});

function Inicio(){
    Load_Pacientes();
    $('#btn_nuevo').click(function () {
        isEditing=false;
        nuevo();
    });
    $('#btn_guardar').click(function () {
        
         GuardarAll();
    });
    $('#btn_cancelar').click(function () {
        isEditing=false;
        nuevo();
    });
    $('.btn_edit_paciente').click(function () {
        var id=$(this).attr('id');
         EditPaciente(id);
    });

    $(".btb_eliminar").on("click", function (s, e) {
        var id = $(this).attr("dta-id_cliente");
        $(this).attr("dta-id_cliente", 3);
        $("#tbl_cleinte").append();
        $("#tbl_cleinte").html(varieblehtml);
        $(input).val();
    });
}
function nuevo(){
    $('#nombre').val("");
    $('#apellido').val("");
    $('#dni').val("");
    $('#txt_date_na').val("");
    $('#direccion').val("");
    $('#telefono').val("");
    $('#email').val("");
    $('#txt_comentario').val("");
    id_paciente=-1;
                    
}
function GuardarAll(){
   
    if(isEditing){
        Update_Paciente();
    }else{
        Insert_Paciente();
    }
}
function EditPaciente(id){
    
    isEditing=true;
    
    $.each(_data, function (i, item) {
        if (item.id_paciente == id) {
            progrres.show(true);
            Load_Pacientes(3);
            $('#nombre').val(item.nombre);
            $('#apellido').val(item.apellido);
            $('#dni').val(item.dni);
            $('#txt_date_na').val(get_Date(item.fec_nacimiento));
            $('#direccion').val(item.direccion);
            $('#telefono').val(item.telefono);
            $('#email').val(item.correo);


            
        }
    });

}
function Load_Pacientes(idCliente){
    var data = {};
    data.id_cleinte = idCliente;
   
    $.ajax({
        type: "POST",
        url: "RegistroPaciente/Get_Paciente",
        data: data,
        async: false,
        datatype: "JSON",
        success: function (response) {
            _data=JSON.parse(response);
           Get_pacientes();

        },
        complete: function () {
            progress.hide();
        }

       
    });
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
function Get_pacientes() {
        $("#tabla_pacientes").empty();
        var tabla='     <thead>';
        tabla+='            <tr>';
        tabla+='                <th>NOMBRE</th>';
        tabla+='                <th>APELLIDOS</th>';
        tabla+='                <th>DNI</th>';
        tabla+='                <th>FECHA NACIMIENTO</th>';
        tabla+='                <th>DIRECCION</th>';
        tabla+='                <th>TELEFONO</th>';
        tabla+='                <th>CORREO</th>';
        tabla+='                <th>EDITAR</th>';
        tabla+='                <th>ELIMINAR</th>';             
        tabla+='              </tr>';
        tabla+='        </thead>';

            tabla+='<tbody>';

            $.each(_data, function (i, item) {
                
                var as='';
                    as+='<button style="margin-top: 10px;" type="button" id='+item.id_paciente+'  class="btn btn-success btn_edit_paciente"><i class="fa fa-edit"></i>';
                    
                    as+='</button>';
               
               // cols += "  <td>" + as + "</td>";

                var btn_edit='';
                    btn_edit+='<button style="margin-top: 10px;" type="button" id='+item.id_paciente+'  class="btn btn-warning btn_remove_paciente"><i class="fa fa-trash"></i>';
                   
                    btn_edit+="</button>";
                
                    tabla+=' <tr>';
                    tabla+='<td >'+item.nombre+'</td>'; 
                    tabla+='<td >'+item.apellido+'</td>'; 
                    tabla+='<td >'+item.dni+'</td>'; 
                    tabla+='<td >'+ get_Date(item.fec_nacimiento)+'</td>'; 
                    tabla+='<td >'+item.direccion +'</td>'; 
                    tabla+='<td >'+item.telefono +'</td>'; 
                    tabla+='<td >'+item.correo +'</td>'; 
                    tabla += "<td>" + as + "</td>";
                    tabla += "<td>" + btn_edit + "</td>"; 
                    tabla+=' </tr>';

    

             });
            tabla+='</tbody>';
            $('#tabla_pacientes').append(tabla);
      
}

function Insert_Paciente(){
    var nombre=$('#nombre').val();
    var apellido=$('#apellido').val();
    var dni=$('#dni').val();
    var fecha=$('#txt_date_na').val();
    var direccion=$('#direccion').val();
    var telefono=$('#telefono').val();
    var email=$('#email').val();
    var comentario=$('#txt_comentario').val();
    if(nombre.length>3&&apellido.length>3&&dni.length>3){

    var data = {};
        data.nombre=nombre;
        data.apellido=apellido;
        data.dni=dni;
        data.fecha=fecha;
        data.direccion=direccion;
        data.telefono=telefono;
        data.email=email;
        data.comentario=comentario;
        $.ajax({
            type: "POST",
            url: "RegistroPaciente/Insert_Client",
            data: data,
            async: false,
            datatype: "JSON",
            success: function (response) {
                if(response=="OK"){
                    $('#myModal2').modal("show");
                        $('#nombre').val("");
                        $('#apellido').val("");
                        $('#dni').val("");
                        $('#txt_date_na').val("");
                        $('#direccion').val("");
                        $('#telefono').val("");
                        $('#email').val("");
                        $('#txt_comentario').val("");
                    Load_Pacientes();
                }else{
                    alert("ERROR FATAL");
                }
               
            }
           
        });
    }else{
        alert("Ingrese Datos");
    }
}
function Update_Paciente(){
    
    var nombre=$('#nombre').val();
    var apellido=$('#apellido').val();
    var dni=$('#dni').val();
    var fecha=$('#txt_date_na').val();
    var direccion=$('#direccion').val();
    var telefono=$('#telefono').val();
    var email=$('#email').val();
    var comentario=$('#txt_comentario').val();
    if(nombre.length>3&&apellido.length>3&&dni.length>3){

    var data = {};
        data.nombre=nombre;
        data.apellido=apellido;
        data.dni=dni;
        data.fecha=fecha;
        data.direccion=direccion;
        data.telefono=telefono;
        data.email=email;
        data.id_paciente=id_paciente;
        $.ajax({
            type: "POST",
            url: "RegistroPaciente/Update_Client",
            data: data,
            async: false,
            datatype: "JSON",
            success: function (response) {
                if(response=="OK"){
                    $('#myModal2').modal("show");
                        $('#nombre').val("");
                        $('#apellido').val("");
                        $('#dni').val("");
                        $('#txt_date_na').val("");
                        $('#direccion').val("");
                        $('#telefono').val("");
                        $('#email').val("");
                        $('#txt_comentario').val("");
                    Load_Pacientes();
                    isEditing=false;
                }else{
                    alert("ERROR FATAL");
                }
               
            }
           
        });
    }else{
        alert("Ingrese Datos");
    }
}
