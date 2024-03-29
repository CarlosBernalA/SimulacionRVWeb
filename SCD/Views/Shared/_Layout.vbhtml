﻿@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <title>Simulacion RV</title>
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/themify-icons/css/themify-icons.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/pace/themes/orange/pace-theme-minimal.css">
    <link rel="stylesheet" href="~/Content/assets/css/vendor/animate/animate.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/x-editable/bootstrap3-editable/css/bootstrap-editable.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap-tour/css/bootstrap-tour.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/jqvmap/jqvmap.min.css">

    @*css para las tabla dinamicas*@
    <link rel="stylesheet" type="text/css" href="~/Content/assets/vendor/datatables/css-main/jquery.dataTables.min.css">
    <link rel="stylesheet" type="text/css" href="~/Content/assets/vendor/datatables/css-bootstrap/dataTables.bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="~/Content/assets/vendor/datatables-tabletools/css/dataTables.tableTools.css">

    <!--<link href="~/Content/assets/css/style.css" rel="stylesheet" />
    <link href="~/Content/assets/css/beyond.min.css" rel="stylesheet" />-->

    <!-- MAIN CSS -->
    <link rel="stylesheet" href="~/Content/assets/css/main.min.css">
    <link rel="stylesheet" href="~/Content/assets/css/skins/sidebar-nav-darkgray.css" type="text/css">
    <link rel="stylesheet" href="~/Content/assets/css/skins/navbar3.css" type="text/css">
    <!-- FOR DEMO PURPOSES ONLY. You should/may remove this in your project -->
    <link rel="stylesheet" href="~/Content/assets/css/demo.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap-colorpicker/css/bootstrap-colorpicker.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/bootstrap-datepicker/css/bootstrap-datepicker3.min.css">    
    <link rel="stylesheet" href="~/Content/assets/vendor/clockpicker/bootstrap-clockpicker.min.css">
    <link rel="stylesheet" href="~/Content/assets/vendor/pace/themes/orange/pace-theme-minimal.css">
    <link rel="stylesheet" href="~/Content/assets/css/proyect-style.css">

    <!-- ICONS -->
    <link rel="apple-touch-icon" sizes="76x76" href="~/Content/assets/img/logo.png">
    <link rel="icon" type="image/png" sizes="96x96" href="~/Content/assets/img/logo.png">
    <!--sortable-->
    <script type="text/javascript" src="~/Content/assets/scripts/html5sortable.js"></script>
    @RenderSection("stylesheet", required:=False)
   @* @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")*@

</head>
<body>
    <!-- WRAPPER -->
    <div id="wrapper">
        <!-- NAVBAR -->
        <nav class="navbar navbar-default navbar-fixed-top">
            <div class="brand">

            </div>
            <div class="container-fluid">
                <div id="tour-fullwidth" class="navbar-btn">
                    <button type="button" class="btn-toggle-fullwidth"><i class="ti-arrow-circle-left"></i></button>
                </div>
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                            <i class="fa fa-user-circle"></i>
                            <span>
                                <font style="vertical-align: inherit;">
                                    <font style="vertical-align: inherit;">Maickol</font>
                                </font>
                            </span>
                        </a>
                        <ul class="dropdown-menu logged-user-menu">
                            <li><a href="#"><i class="ti-user"></i> <span><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Mi perfil</font></font></span></a></li>
                            <li><a href="#"><i class="ti-email"></i> <span><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Mensaje</font></font></span></a></li>
                            <li><a href="#"><i class="ti-settings"></i> <span><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Configuraciones</font></font></span></a></li>
                            <li><a href="login"><i class="ti-power-off"></i> <span><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Cerrar sesión</font></font></span></a></li>
                        </ul>
                    </li>
                </ul>
                
            </div>
        </nav>
        <!-- END NAVBAR -->
        <!-- LEFT SIDEBAR -->
        <div id="sidebar-nav" class="sidebar">
            <nav>
                <ul class="nav" id="sidebar-nav-menu">
                    <li class="menu-group active" style="font-weight: 700; font-size: 1.6rem;">
                        <center><a href="Principal" style="color: #929598 !important;">Simulación RV</a></center>
                    </li>

                    <li class="panel">
                        <a href="#Mantenimiento" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father">
                            <i class="fa fa-address-card"></i> <span class="title">Mantenimiento</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="Mantenimiento" class="collapse ">
                            <ul class="submenu">
                                <li><a href="Area" id="li_area">Area</a></li>
                                <li><a href="Rol" id="li_rol">Rol</a></li>
                                <li><a href="Trabajador" id="li_trabajador">Trabajador</a></li>
                                <li><a href="Asignacionrol" id="li_asignacionrol">Asignacion de Roles</a></li>                                     
                            </ul>
                        </div>
                    </li>
                    <li class="panel">
                        <a href="#Administrar" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father">
                            <i class="fa fa-wrench"></i> <span class="title">Administrar</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="Administrar" class="collapse ">
                            <ul class="submenu">
                                <li><a href="Local" id="li_local">Local</a></li>
                                <li><a href="Programa" id="li_programa">Programa</a></li>
                                <li><a href="Simulacion" id="li_simulacion">Simulación</a></li>
                                <li><a href="Tiposimulacion" id="li_tiposimulacion">Tipo de Simulación</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="panel">
                        <a href="#Resultados" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father">
                            <i class="fa fa-address-card"></i> <span class="title">Resultados</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="Resultados" class="collapse ">
                            <ul class="submenu">
                                <li><a href="Area" id="li_resultados">Simulaciones Realizadas</a></li>
                            </ul>
                        </div>
                    </li>

                </ul>
                <button type="button" class="btn-toggle-minified" title="Toggle Minified Menu"><i class="ti-arrows-horizontal"></i></button>
            </nav>
        </div>
        <!-- END LEFT SIDEBAR -->
        <!-- MAIN -->
        <div class="main">
            <!-- MAIN CONTENT -->
            <div class="main-content">
                @*<div id="inicio" hidden>
                    @Html.Partial("_Inicio")
                    </div>
                    <div id="pacientes" >
                    @Html.Partial("_Paciente")
                    </div>*@
                @RenderBody()

            </div>
            <!-- END MAIN CONTENT -->
            <!-- RIGHT SIDEBAR -->
            <!-- END RIGHT SIDEBAR -->
        </div>
        <!-- END MAIN -->
        <div class="clearfix"></div>

    </div>
    <!-- END WRAPPER -->
    <!-- Javascript -->
  

    <script src="~/Content/assets/vendor/jquery/jquery.min.js"></script>
    <script src="~/Content/assets/vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="~/Content/assets/vendor/pace/pace.min.js"></script>
    <script src="~/Content/assets/vendor/bootstrap-progressbar/js/bootstrap-progressbar.min.js"></script>
    <script src="~/Content/assets/vendor/Flot/jquery.flot.js"></script>
    <script src="~/Content/assets/vendor/Flot/jquery.flot.resize.js"></script>
    <script src="~/Content/assets/vendor/Flot/jquery.flot.time.js"></script>
    <script src="~/Content/assets/vendor/flot.tooltip/jquery.flot.tooltip.js"></script>
    <script src="~/Content/assets/vendor/x-editable/bootstrap3-editable/js/bootstrap-editable.min.js"></script>
    <script src="~/Content/assets/vendor/jquery.maskedinput/jquery.maskedinput.min.js"></script>
    <script src="~/Content/assets/vendor/moment/min/moment.min.js"></script>
    <script src="~/Content/assets/vendor/jquery-sparkline/js/jquery.sparkline.min.js"></script>
    <script src="~/Content/assets/vendor/bootstrap-tour/js/bootstrap-tour.min.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/widget.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/data.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/scroll-parent.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/disable-selection.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/widgets/mouse.js"></script>
    <script src="~/Content/assets/vendor/jquery-ui/ui/widgets/sortable.js"></script>
    <script src="~/Content/assets/vendor/datatables/js-main/jquery.dataTables.min.js"></script>
    <script src="~/Content/assets/vendor/datatables/js-bootstrap/dataTables.bootstrap.min.js"></script>
    <script src="~/Content/assets/vendor/jquery-appear/jquery.appear.min.js"></script>
    <script src="~/Content/assets/vendor/jqvmap/jquery.vmap.min.js"></script>
    <script src="~/Content/assets/vendor/jqvmap/maps/jquery.vmap.world.js"></script>
    <script src="~/Content/assets/vendor/jqvmap/maps/jquery.vmap.usa.js"></script>
    <script src="~/Content/assets/vendor/chart-js/Chart.min.js"></script>
    <script src="~/Content/assets/vendor/raphael/raphael.min.js"></script>
    <script src="~/Content/assets/vendor/justgage-toorshia/justgage.js"></script>
    <script src="~/Content/assets/scripts/klorofilpro-common.min.js"></script>

    <script src="~/Content/assets/vendor/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script src="~/Content/assets/vendor/clockpicker/bootstrap-clockpicker.min.js"></script>
    <script src="~/Content/assets/vendor/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js"></script>

    <script src="~/Content/assets/amcharts/amcharts.js"></script>
    <script src="~/Content/assets/amcharts/serial.js"></script>
    <script src="~/Content/assets/amcharts/plugins/export/export.min.js"></script>
    <link href="~/Content/assets/amcharts/plugins/export/export.css" rel="stylesheet" />
    <script src="~/Content/assets/amcharts/themes/light.js"></script>  

    <!-- script de tablas dinamicas -->
    <script src="~/Content/assets/vendor/datatables/js-main/jquery.dataTables.min.js"></script>
    <script src="~/Content/assets/vendor/datatables/js-bootstrap/dataTables.bootstrap.min.js"></script>
    <script src="~/Content/assets/vendor/datatables-colreorder/dataTables.colReorder.js"></script>
    <script src="~/Content/assets/vendor/datatables-tabletools/js/dataTables.tableTools.js"></script>
    <script src="~/Content/assets/scripts/Script_function.js"></script> 

    <!--nestable-->
    <link rel="stylesheet" type="text/css" href="~/Content/assets/vendor/nestable2/jquery.nestable.css">

    @RenderSection("scripts", required:=False)
</body>
</html>
