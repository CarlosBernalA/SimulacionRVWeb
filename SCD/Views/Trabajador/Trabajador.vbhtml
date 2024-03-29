﻿@Code
    Layout = "~/Views/Shared/_layout.vbhtml"

End Code
@Section Scripts
    <script src="~/Content/assets/scripts/Script_Trabajador.js"></script>
End Section
<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title" id="view-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Trabajador</font></font></h1>
        <p class="page-subtitle" id="view-description"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Panel de administracion de los trbajadores</font></font></p>
    </div>
    <ul class="breadcrumb" id="view-breadcrumb">
        <li class="home"><a href="Principal"><i class="fa fa-home"></i><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Principal</font></font></a></li>
        <li class="active"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Trabajador </font></font></li>
    </ul>
</div>
<!--panel trabajadores-->
<div class="panel">
    <div class="panel-heading">
        <h3 class="panel-title">Lista de trabajadores</h3>
        <button type="button" class="btn btn-primary agregarCiudadano" data-toggle="modal" data-target="#agregartrabajador" style="margin-top: -9px">
            <i class="fa fa-plus-square"></i> <span>Agregar Trabajador</span>
        </button>
    </div>
    <div class="panel-body">

        <table id="datatable-persons" class="table table-striped table-hover table-bordered">
            <thead>
                <tr>
                    <th id="PersonName">DNI</th>
                    <th id="DNI">Apellidos</th>
                    <th id="Sex">Nombres</th>
                    <th id="Age">Area</th>
                    <th id="DistrictName">Sexo</th>
                    <th id="CommunityName">Direccion</th>
                    <th>OPCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr role="row">
                    <td>465374626</td>
                    <td>Salazar Mejia</td>
                    <td>Maickol</td>
                    <td>Tecnologia de la información</td>
                    <td>Masculino</td>
                    <td>Casma</td>
                    <td><center>
                            <button type="button" class="btn btn-default btn-sm" data-toggle="modal" data-target="#editartrabajador">
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
<!--modal agregar trabajador-->
<div class="modal fade" id="agregartrabajador" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Agregar trabajador</p>
            </div>
            <div class="modal-body">
                <div class="row pb1 mt1 mb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-7">
                                <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Area</font></font></legend>
                                <select class="form-control">
                                    <option value="cheese">Contabilidad</option>
                                    <option value="cheese">Largos</option>
                                    <option value="cheese">TI</option>
                                </select>
                            </div>
                            <div class="col-md-5">
                                <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Inico de trabajo</font></font></legend>
                                <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row bg-gris pt2">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Información personal</font></font></legend>
                    </div>
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                <label class="control-label">DNI:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Nombre:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">Apellidos:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row bg-gris pt2 pb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                <label class="control-label">Sexo:</label>
                                <div class="fancy-radio">
                                    <label>
                                        <input name="gender" value="male" type="radio">
                                        <span><i></i>
                                            <font style="vertical-align: inherit;">
                                            <font style="vertical-align: inherit;">Masculino</font>
                                            </font>
                                        </span>
                                    </label>
                                </div>
                                <div class="fancy-radio">
                                    <label>
                                        <input name="gender" value="female" type="radio">
                                        <span><i></i>
                                            <font style="vertical-align: inherit;">
                                            <font style="vertical-align: inherit;">Femenino</font>
                                            </font>
                                        </span>
                                    </label>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Fecha de Nacimiento:</label>
                                <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">Dirección:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mt2 mb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Registro de cuenta</font></font></legend>
                    </div>
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-2">
                                
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Usuario:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Contraseña:</label>
                                <div class="hideShowPassword-wrapper" style="position: relative; display: block; vertical-align: baseline; margin: 0px;">
                                    <input type="password" class="form-control hideShowPassword-field hideShowPassword-hidden" id="password-showhide2" autocapitalize="off" autocomplete="off" spellcheck="true" style="margin: 0px; padding-right: 26px;">
                                    <button type="button" role="button" aria-label="Show Password" title="Show Password" tabindex="0" class="hideShowPassword-toggle toggle-eye hideShowPassword-toggle-show" aria-pressed="false" style="position: absolute; right: 0px; top: 50%; margin-top: -10.5px;">
                                        <i class="fa fa-eye"></i>
                                    </button>
                                </div>
                            </div>
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
<!--modal editar trabajador-->
<div class="modal fade" id="editartrabajador" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Editar trabajador</p>
            </div>
            <div class="modal-body">
                <div class="row pb1 mt1 mb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-7">
                                <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Area</font></font></legend>
                                <select class="form-control">
                                    <option value="cheese">Contabilidad</option>
                                    <option value="cheese">Largos</option>
                                    <option value="cheese">TI</option>
                                </select>
                            </div>
                            <div class="col-md-5">
                                <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Inico de trabajo</font></font></legend>
                                <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row bg-gris pt2">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Información personal</font></font></legend>
                    </div>
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                <label class="control-label">DNI:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Nombre:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">Apellidos:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row bg-gris pt2 pb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                <label class="control-label">Sexo:</label>
                                <div class="fancy-radio">
                                    <label>
                                        <input name="gender" value="male" type="radio">
                                        <span>
                                            <i></i>
                                            <font style="vertical-align: inherit;">
                                                <font style="vertical-align: inherit;">Masculino</font>
                                            </font>
                                        </span>
                                    </label>
                                </div>
                                <div class="fancy-radio">
                                    <label>
                                        <input name="gender" value="female" type="radio">
                                        <span>
                                            <i></i>
                                            <font style="vertical-align: inherit;">
                                                <font style="vertical-align: inherit;">Femenino</font>
                                            </font>
                                        </span>
                                    </label>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Fecha de Nacimiento:</label>
                                <input data-provide="datepicker" data-date-autoclose="true" class="form-control" data-date-format="dd/mm/yyyy">
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">Dirección:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mt2 mb1">
                    <div class="col-md-12">
                        <legend><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Registro de cuenta</font></font></legend>
                    </div>
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-2">

                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Usuario:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-4">
                                <label class="control-label">Contraseña:</label>
                                <div class="hideShowPassword-wrapper" style="position: relative; display: block; vertical-align: baseline; margin: 0px;">
                                    <input type="password" class="form-control hideShowPassword-field hideShowPassword-hidden" id="password-showhide2" autocapitalize="off" autocomplete="off" spellcheck="true" style="margin: 0px; padding-right: 26px;">
                                    <button type="button" role="button" aria-label="Show Password" title="Show Password" tabindex="0" class="hideShowPassword-toggle toggle-eye hideShowPassword-toggle-show" aria-pressed="false" style="position: absolute; right: 0px; top: 50%; margin-top: -10.5px;">
                                        <i class="fa fa-eye"></i>
                                    </button>
                                </div>
                            </div>
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

