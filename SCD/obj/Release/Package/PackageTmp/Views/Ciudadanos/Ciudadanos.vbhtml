
@Code
    Layout = "~/Views/Shared/_layout.vbhtml"
End Code
@Section Scripts
<script src="~/Content/assets/scripts/Script_Ciudadanos.js"></script>
End Section
<div class="container-fluid">
    <div class="row" style="margin-top:3rem">
        <div class="col-md-3 col-sm-6">
            <div class="widget widget-metric_1 animate">
                <span class="icon-wrapper custom-bg-orange"><i class="fa fa-area-chart"></i></span>
                <div class="right">
                    <span class="value">3642 <i class="change-icon change-up fa fa-sort-up text-indicator-green"></i></span>
                    <span class="title">Población</span>
                </div>
            </div>
        </div>
        <div class="col-md-3 col-sm-6">
            <div class="widget widget-metric_1 animate">
                <span class="icon-wrapper custom-bg-lightseagreen"><i class="fa fa-shopping-cart"></i></span>
                <div class="right">
                    <span class="value">8740 <i class="change-icon change-up fa fa-sort-up text-indicator-green"></i></span>
                    <span class="title">Hombres</span>
                </div>
            </div>
        </div>
        <div class="col-md-3 col-sm-6">
            <div class="widget widget-metric_1 animate">
                <span class="icon-wrapper custom-bg-blue2"><i class="fa fa-user"></i></span>
                <div class="right">
                    <span class="value">2567 <i class="change-icon change-up fa fa-sort-up text-indicator-green"></i></span>
                    <span class="title">Mujeres</span>
                </div>
            </div>
        </div>
        <div class="col-md-3 col-sm-6">
            <div class="widget widget-metric_1 animate">
                <span class="icon-wrapper custom-bg-purple"><i class="fa fa-envelope"></i></span>
                <div class="right">
                    <span class="value">56.72% <i class="change-icon change-down fa fa-sort-down text-indicator-red"></i></span>
                    <span class="title">Muertes</span>
                </div>
            </div>
        </div>

    </div>
</div>

<div class="container agregarCiudadano">
    <center>
        <button type="button" class="btn btn-primary btn-lg">
            <i class="fa fa-plus-square"></i> <span>Agregar Ciudadano</span>
        </button>
    </center>
</div>
                                  
<div class="panel">
        <div class="panel-heading">
            <h3 class="panel-title">Titulo de la tabla</h3>
        </div>
        <div class="panel-body">
            <table id="datatable-persons" class="table table-striped table-hover table-bordered">
                <thead>
                    <tr>
                        <th id="PersonName">Nobre</th>
                        <th id="DNI">DNI</th>
                        <th id="Sex">SEXO</th>
                        <th id="Age">EDAD</th>
                        <th id="DistrictName">DISTRITO</th>
                        <th id="CommunityName">COMUNIDAD</th>
                        <th>OPCIONES</th>
                    </tr>
                </thead>
                <tbody >

                </tbody>
            </table>
        </div>
    </div>
