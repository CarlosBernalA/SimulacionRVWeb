﻿@Code
    Layout = "~/Views/Shared/_layout.vbhtml"

End Code
@Section Scripts
    <script src="~/Content/assets/scripts/Script_AsignacionRol.js"></script>
End Section
<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title" id="view-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Asignacion de roles</font></font></h1>
        <p class="page-subtitle" id="view-description"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Panel de administracion para asignar roles</font></font></p>
    </div>
    <ul class="breadcrumb" id="view-breadcrumb">
        <li class="home"><a href="Principal"><i class="fa fa-home"></i><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Principal</font></font></a></li>
        <li class="active"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Asignacion de Roles </font></font></li>
    </ul>
</div>
<!--panel trabajadores-->
<div class="panel">
    <div class="panel-heading">
        <h3 class="panel-title">Lista de trabajadores</h3>
    </div>
    <div class="panel-body">

        <table id="datatable-persons" class="table table-striped table-hover table-bordered">
            <thead>
                <tr>
                    <th>Trabajador</th>
                    <th>Rol</th>
                    <th>Descripción</th>
                    <th>OPCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr role="row">
                    <td>Maickol</td>
                    <td>Administrador</td>
                    <td>Persona responsable de establecer y mantener el sistema</td>
                    <td>
                        <center>
                            <button type="button" class="btn btn-default btn-sm" data-toggle="modal" data-target="#asignarroles">
                                <i class="fa fa-clipboard"></i>
                            </button>
                        </center>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<!-- /.modal -->
<!--modal asignar roles-->
<div class="modal fade" id="asignarroles" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Asignacion de Roles</p>
            </div>
            <div class="modal-body">
                <center><h3 class="panel-title mt2">Salazar Mejia Maickol</h3></center>
                <div class="row mt2">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-5">
                                <label class="control-label">Rol:</label>
                                <select class="form-control">
                                    <option value="cheese">Administrador</option>
                                    <option value="cheese">rolll</option>
                                    <option value="cheese">rooooo</option>
                                </select>
                            </div>
                            <div class="col-md-4">
                                <br />
                                <button type="button" class="btn btn-primary"><i class="fa fa-plus-square"></i> Agregar Rol</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mt2">
                    <div class="col-md-12" style="padding-left:7rem;padding-right:7rem">
                        <div class="widget widget-metric_6 mb1" style="padding:1rem;box-shadow: 2px 2px 4px #cccccc;">
                            <span>Administrador</span>
                            <i class='fa fa-trash-o' style="float: right;color: red;font-size: 2rem;margin-top: -1px;margin-right: 5px;cursor: pointer;"></i>
                        </div>
                        <div class="widget widget-metric_6 mb1" style="padding:1rem;box-shadow: 2px 2px 4px #cccccc;">
                            <span>Responsable</span>
                            <i class='fa fa-trash-o' style="float: right;color: red;font-size: 2rem;margin-top: -1px;margin-right: 5px;cursor: pointer;"></i>
                        </div>
                        <div class="widget widget-metric_6 mb1" style="padding:1rem;box-shadow: 2px 2px 4px #cccccc;">
                            <span>otros</span>
                            <i class='fa fa-trash-o' style="float: right;color: red;font-size: 2rem;margin-top: -1px;margin-right: 5px;cursor: pointer;"></i>
                        </div>
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
