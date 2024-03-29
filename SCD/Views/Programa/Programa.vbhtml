﻿
@Code
    Layout = "~/Views/Shared/_layout.vbhtml"

End Code
@Section Scripts
    <script src="~/Content/assets/scripts/Script_Programa.js"></script>
End Section
<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title" id="view-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Programa</font></font></h1>
        <p class="page-subtitle" id="view-description"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Panel de administracion para programas</font></font></p>
    </div>
    <ul class="breadcrumb" id="view-breadcrumb">
        <li class="home"><a href="Principal"><i class="fa fa-home"></i><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Principal</font></font></a></li>
        <li class="active"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Programa </font></font></li>
    </ul>
</div>
<!--panel lista de programas-->
<div class="panel" id="listaprograma">
    <div class="panel-heading">
        <h3 class="panel-title">Lista de programas</h3>
        <button type="button" class="btn btn-primary agregarCiudadano" data-toggle="modal" data-target="#agregarprograma" style="margin-top: -9px">
            <i class="fa fa-plus-square"></i> <span>Agregar Programa</span>
        </button>
    </div>
    <div class="panel-body">

        <table id="datatable-persons" class="table table-striped table-hover table-bordered">
            <thead>
                <tr>
                    <th>Trbajador Rol</th>
                    <th>Simulación</th>
                    <th>Local</th>
                    <th>Participantes</th>
                    <th>Fecha</th>
                    <th>Hora Inicio</th>
                    <th>Hora Fin</th>
                    <th>Descripción</th>
                    <th>OPCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr role="row">
                    <td>Maickol</td>
                    <td>Protocolo de Mantenimiento</td>
                    <td>Industrial A</td>
                    <td>10</td>
                    <td>23-10-2019</td>
                    <td>09:00</td>
                    <td>12:00</td>
                    <td>Programa para la Realidad Virtual</td>
                    <td>
                        <center>
                            <button type='button' class='btn btn-default btn-sm' id="editprograma">
                                <i class='fa fa-edit'></i>
                            </button>
                        </center>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<!-- panel editar programa-->
<div class="panel" id="editarprograma" style="display:none">
    <div class="panel-heading">
        <h3 class="panel-title">Editar programa</h3>
        <button type="button" class="btn btn-danger agregarCiudadano btn-sm" id="listprograma" style="margin-top: -8px;padding-right:13px;">
            <i class="fa fa-remove" style="font-size:17px"></i>
        </button>    
    </div>
    <div class="panel-body">
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-6">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Local</font></font></legend>
                        <select class="form-control">
                            <option value="cheese">Industrial A</option>
                            <option value="cheese">Largos</option>
                            <option value="cheese">TI</option>
                        </select>
                    </div>
                    <div class="col-md-6">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Simulacion</font></font></legend>
                        <select class="form-control">
                            <option value="cheese">Protocolo de Mantenimiento</option>
                            <option value="cheese">Largos</option>
                            <option value="cheese">TI</option>
                        </select>
                    </div>
                    <div class="col-md-12 mt2">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Descripción</font></font></legend>
                        <textarea class="form-control" rows="2" cols="30" required=""></textarea>
                    </div>
                </div>
                <div class="row bg-gris mt1 pt1 pb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Fecha y Hora</font></font></legend>
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Fecha del Programa:</label>
                        <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Inicio:</label>
                        <div class="input-group basic-clockpicker" data-placement="top" data-autoclose="true">
                            <input type="text" class="form-control" value="09:30">
                            <span class="input-group-addon">
                                <span class="fa fa-clock-o"></span>
                            </span>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Fin:</label>
                        <div class="input-group basic-clockpicker" data-placement="top" data-autoclose="true">
                            <input type="text" class="form-control" value="09:30">
                            <span class="input-group-addon">
                                <span class="fa fa-clock-o"></span>
                            </span>
                        </div>
                    </div>

                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Participantes</font></font></legend>
                    </div>
                    
                    <div class="col-md-12" style="padding-right: 85px;">
                        <label class="control-label">Trabajador:</label>
                        <input type="text" class="form-control" placeholder="">
                        <button type="button" class="btn btn-primary btn-sm" style="float:right;margin-top:-32px;margin-right:-58px;">
                            <i class="fa fa-plus-square"></i>
                        </button>
                    </div>
                    <div class="col-md-12 mt2">
                        <textarea class="form-control" rows="7" cols="30" required=""></textarea>

                    </div>
                </div>
            </div>
        </div>
       
        
    </div>
</div>
<!--modal agregar programa-->
<div class="modal fade" id="agregarprograma" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Nuevo Programa</p>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-4">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Local</font></font></legend>
                        <select class="form-control">
                            <option value="cheese">Industria A</option>
                            <option value="cheese">Largos</option>
                            <option value="cheese">TI</option>
                        </select>
                    </div>
                    <div class="col-md-4">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Simulacion</font></font></legend>
                        <select class="form-control">
                            <option value="cheese">Protocolo de Mantenimiento</option>
                            <option value="cheese">Largos</option>
                            <option value="cheese">TI</option>
                        </select>
                    </div>
                    <div class="col-md-4">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Descripción</font></font></legend>
                        <textarea class="form-control" rows="1" cols="30" required=""></textarea>
                    </div>
                </div>
                <div class="row bg-gris mt1 pt1 pb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Fecha y Hora</font></font></legend>
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Fecha del Programa:</label>                        
                        <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Inicio:</label>
                        <div class="input-group basic-clockpicker" data-placement="top" data-autoclose="true">
                            <input type="text" class="form-control" value="09:30">
                            <span class="input-group-addon">
                                <span class="fa fa-clock-o"></span>
                            </span>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <label class="control-label">Fin:</label>
                        <div class="input-group basic-clockpicker" data-placement="top" data-autoclose="true">
                            <input type="text" class="form-control" value="09:30">
                            <span class="input-group-addon">
                                <span class="fa fa-clock-o"></span>
                            </span>
                        </div>                    
                    </div>

                </div>
                <div class="row mt1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Participantes</font></font></legend>
                    </div>
                    <div class="col-md-7">
                        <textarea class="form-control" rows="7" cols="30" required=""></textarea>

                    </div>
                    <div class="col-md-5" style="padding-right: 85px;">
                        <label class="control-label">Trabajador:</label>
                        <input type="text" class="form-control" placeholder="">
                        <button type="button" class="btn btn-primary btn-sm" style="float:right;margin-top:-32px;margin-right:-58px;">
                            <i class="fa fa-plus-square"></i>
                        </button>
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

