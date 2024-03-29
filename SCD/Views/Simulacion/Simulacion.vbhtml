﻿@Code
    Layout = "~/Views/Shared/_layout.vbhtml"

End Code
@Section Stylesheet
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap-slider/slider.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/nouislider/css/nouislider.min.css">
End Section
@Section Scripts
    <script src="~/Content/assets/scripts/Script_Simulacion.js"></script>
    <script type="text/javascript" src="~/Content/assets/vendor/bootstrap-slider/bootstrap-slider.js"></script>
    <script type="text/javascript" src="~/Content/assets/vendor/wnumb/wNumb.js"></script>
    <script type="text/javascript" src="~/Content/assets/vendor/nouislider/js/nouislider.min.js"></script>
    <script type="text/javascript" src="~/Content/assets/scripts/forms-input-sliders.js"></script>
End Section
<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title" id="view-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Simulacion</font></font></h1>
        <p class="page-subtitle" id="view-description"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Panel de administracion de las simulaciones</font></font></p>
    </div>
    <ul class="breadcrumb" id="view-breadcrumb">
        <li class="home"><a href="Principal"><i class="fa fa-home"></i><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Principal</font></font></a></li>
        <li class="active"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"> Simulación </font></font></li>
    </ul>
</div>
<!--panel simulaciones-->
<div class="panel">
    <div class="panel-heading">
        <h3 class="panel-title">Lista de simulaciones</h3>
        <button type="button" class="btn btn-primary agregarCiudadano" data-toggle="modal" data-target="#agregarsimulacion" style="margin-top: -9px">
            <i class="fa fa-plus-square"></i> <span>Agregar Simulación</span>
        </button>
    </div>
    <div class="panel-body">

        <table id="datatable-persons" class="table table-striped table-hover table-bordered">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Tipo de Simulación</th>
                    <th>Descripcion</th>
                    <th>Maximo puntaje</th>
                    <th>Grado de Riesgo</th>
                    <th>OPCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr role="row">
                    <td>Protocolo de Mantenimiento</td>
                    <td>Capacitación</td>
                    <td>Listado de tareas a realizar en un tipo concreto de equipo.</td>
                    <td>90</td>
                    <td>5</td>
                    <td>
                        <center>
                            <button type="button" class="btn btn-default btn-sm" data-toggle="modal" data-target="#editarsimulacion">
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
<!--modal agregar simulacion-->
<div class="modal fade" id="agregarsimulacion" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Agregar Simulacion</p>
            </div>
            <div class="modal-body">
                <div class="row mt2 mb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-6">
                                <label class="control-label">Nombre:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-6">
                                <label class="control-label">Tipo de Simulación:</label>
                                <select class="form-control">
                                    <option value="cheese">Capacitación</option>
                                    <option value="cheese">Largos</option>
                                    <option value="cheese">TI</option>
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mb1">
                    <div class="col-md-12">
                        <label class="control-label">Descripción:</label>
                        <textarea class="form-control" rows="4" cols="30" required=""></textarea>
                    </div>
                </div>
                <div class="row mb1">
                    <div class="col-md-12">
                        <label class="control-label">Puntuación maxima permitida:</label>
                        <div class="slider-has-label">
                            <div class="left-slider">
                                <div class="slider slider-horizontal" style="width: 163px;"><div class="slider-track"><div class="slider-selection" style="left: 0%; width: 0%;"></div><div class="slider-handle" style="left: 0%;"></div><div class="slider-handle hide" style="left: 0%;"></div></div><div class="tooltip top hide" style="top: -30px; left: 0px;"><div class="tooltip-arrow"></div><div class="tooltip-inner">0</div></div><input id="slider" type="text" class="bootstrap-slider" value="" style="display: none;"></div>
                            </div>
                            <div class="right-label">
                                <span class="label label-default label-slider pull-right">0</span>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <label class="control-label">Grado de riesgo:</label>
                        <div class="slider-has-label">
                            <div class="left-slider">
                                <div class="slider slider-horizontal" style="width: 163px;"><div class="slider-track"><div class="slider-selection" style="left: 0%; width: 0%;"></div><div class="slider-handle" style="left: 0%;"></div><div class="slider-handle hide" style="left: 0%;"></div></div><div class="tooltip top hide" style="top: -30px; left: 0px;"><div class="tooltip-arrow"></div><div class="tooltip-inner">0</div></div><input type="text" class="bootstrap-slider" value="" style="display: none;"></div>
                            </div>
                            <div class="right-label">
                                <span class="label label-default label-slider pull-right">0</span>
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
<!--modal editar simulacion-->
<div class="modal fade" id="editarsimulacion" tabindex="-1" role="dialog" aria-labelledby="gridSystemModalLabel">
    <div class="modal-dialog" role="document">
        <div class="modal-content" style="border: 1px solid;">
            <div class="modal-header" style="background-color: #03A6F0; color: white; border-top-left-radius: 5px; border-top-right-radius: 5px; padding:11px">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 2.7rem;">&times;</span></button>
                <p class="modal-title" id="gridSystemModalLabel" style="font-size: 17px;">Agregar Simulacion</p>
            </div>
            <div class="modal-body">
                <div class="row mt2 mb1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-6">
                                <label class="control-label">Nombre:</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <div class="col-md-6">
                                <label class="control-label">Tipo de Simulación:</label>
                                <select class="form-control">
                                    <option value="cheese">Capacitación</option>
                                    <option value="cheese">Largos</option>
                                    <option value="cheese">TI</option>
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mb1">
                    <div class="col-md-12">
                        <label class="control-label">Descripción:</label>
                        <textarea class="form-control" rows="4" cols="30" required=""></textarea>
                    </div>
                </div>
                <div class="row mb1">
                    <div class="col-md-12">
                        <label class="control-label">Puntuación maxima permitida:</label>
                        <div class="slider-has-label">
                            <div class="left-slider">
                                <div class="slider slider-horizontal" style="width: 163px;"><div class="slider-track"><div class="slider-selection" style="left: 0%; width: 0%;"></div><div class="slider-handle" style="left: 0%;"></div><div class="slider-handle hide" style="left: 0%;"></div></div><div class="tooltip top hide" style="top: -30px; left: 0px;"><div class="tooltip-arrow"></div><div class="tooltip-inner">0</div></div><input id="slider" type="text" class="bootstrap-slider" value="" style="display: none;"></div>
                            </div>
                            <div class="right-label">
                                <span class="label label-default label-slider pull-right">0</span>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <label class="control-label">Grado de riesgo:</label>
                        <div class="slider-has-label">
                            <div class="left-slider">
                                <div class="slider slider-horizontal" style="width: 163px;"><div class="slider-track"><div class="slider-selection" style="left: 0%; width: 0%;"></div><div class="slider-handle" style="left: 0%;"></div><div class="slider-handle hide" style="left: 0%;"></div></div><div class="tooltip top hide" style="top: -30px; left: 0px;"><div class="tooltip-arrow"></div><div class="tooltip-inner">0</div></div><input type="text" class="bootstrap-slider" value="" style="display: none;"></div>
                            </div>
                            <div class="right-label">
                                <span class="label label-default label-slider pull-right">0</span>
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
