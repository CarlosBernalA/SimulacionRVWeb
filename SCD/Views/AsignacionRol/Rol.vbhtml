﻿@Code
    Layout = "~/Views/Shared/_layout.vbhtml"

End Code
@Section Scripts
    <script src="~/Content/assets/scripts/Script_Rol.js"></script>
End Section
<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title" id="view-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Rol</font></font></h1>
        <p class="page-subtitle" id="view-description"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Panel de administracion de los roles</font></font></p>
    </div>
    <ul class="breadcrumb" id="view-breadcrumb">
        <li class="home"><a href="Principal"><i class="fa fa-home"></i><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Principal</font></font></a></li>
        <li class="active"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Rol </font></font></li>
    </ul>
</div>
<!--panel lista de roles-->
<div class="panel">
    <div class="panel-heading">
        <h3 class="panel-title">Lista de roles</h3>
        <button type="button" class="btn btn-primary agregarCiudadano" data-toggle="modal" data-target="#agregarrol" style="margin-top: -9px">
            <i class="fa fa-plus-square"></i> <span>Agregar rol</span>
        </button>
    </div>
    <div class="panel-body">

        <table id="datatable-persons" class="table table-striped table-hover table-bordered">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Descripción</th>
                    
                    <th>OPCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr role="row">
                    <td>Administrador</td>
                    <td>Persona responsable de establecer y mantener el sistema</td>
                    
                    <td>
                        <center>
                            <button type="button" class="btn btn-default btn-sm" data-toggle="modal" data-target="#editarrol">
                                <i class="fa fa-edit"></i>
                            </button>
                            <button type='button' class='borrar btn btn-danger btn-sm'><i class='fa fa-trash-o'></i></button>
                        </center>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<!--modal agregar rol-->
<div class="modal fade" id="agregarrol" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Agregar Rol</p>
            </div>
            <div class="modal-body">
                <div class="row pb1 mt2 mb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Nombre</font></font></legend>
                        <input type="text" class="form-control" placeholder="">
                    </div>
                    <div class="col-md-12 mt2">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Descripción</font></font></legend>
                        <textarea class="form-control" rows="7" cols="30" required=""></textarea>
                    </div>
                </div>
            </div>
            <div class="modal-footer" style="padding: 10px;">
                <button type="button" class="btn btn-default" data-dismiss="modal">Calcelar</button>
                <button type="button" class="btn btn-primary">Guardar</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div>
<!--modal editar rol-->
<div class="modal fade" id="editarrol" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Editar rol</p>
            </div>
            <div class="modal-body">
                <div class="row pb1 mt2 mb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Nombre</font></font></legend>
                        <input type="text" class="form-control" placeholder="">
                    </div>
                    <div class="col-md-12 mt2">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Descripción</font></font></legend>
                        <textarea class="form-control" rows="7" cols="30" required=""></textarea>
                    </div>
                </div>
            </div>
            <div class="modal-footer" style="padding: 10px;">
                <button type="button" class="btn btn-default" data-dismiss="modal">Calcelar</button>
                <button type="button" class="btn btn-primary">Guardar</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div>
<!-- /.modal -->