@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <title>Proyecto Municipalidad distrital de Chota</title>
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
    <link rel="apple-touch-icon" sizes="76x76" href="~/Content/assets/img/apple-icon.png">
    <link rel="icon" type="image/png" sizes="96x96" href="~/Content/assets/img/favicon.png">
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
                <form class="navbar-form navbar-left search-form">
                    <input type="text" value="" class="form-control" placeholder="Search dashboard...">
                    <button type="button" class="btn btn-default"><i class="fa fa-search"></i></button>
                </form>

            </div>
        </nav>
        <!-- END NAVBAR -->
        <!-- LEFT SIDEBAR -->
        <div id="sidebar-nav" class="sidebar">
            <nav>
                <ul class="nav" id="sidebar-nav-menu">
                    <li class="menu-group" style="font-weight: 700;"><center>Municipalidad Provincial de Chota</center></li>

                    <li class="panel">
                        <a href="#inicio" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father">
                            <i class="ti-dashboard"></i> <span class="title">Inicio</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="inicio" class="collapse ">
                                <ul class="submenu">
                                    <li><a href="Inicio" id="li_inicio">Genaral</a></li>                                    
                                </ul>
                            </div>
                    </li>
                    <li class="panel">
                        <a href="#mantenimiento" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father collapsed">
                            <i class="fa fa-wrench"></i> <span class="title">Mantenimiento</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="mantenimiento" class="collapse ">
                            <ul class="submenu">
                                <li><a href="ciudadanos" id="li_ciudadanos">Ciudadanos </a></li>
                                <li><a href="distritos" id="li_distrito">Distritos</a></li>
                                <li><a href="caserio" id="li_caserio">Caserios</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="panel">
                        <a href="#creacionDeProyecto" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father collapsed">
                            <i class="fa fa-tasks"></i> <span class="title">Creación de Proyecto</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="creacionDeProyecto" class="collapse ">
                            <ul class="submenu">
                                <li><a href="nuevoProyecto" id="li_nuevoProyecto">Nuevo Proyecto</a></li>
                                <li><a href="listaProyecto" id="li_listaProyecto">Lista de Proyectos</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="panel">
                        <a href="#encuestas" data-toggle="collapse" data-parent="#sidebar-nav-menu" class="father collapsed">
                            <i class="ti-receipt"></i> <span class="title">Encuestas</span> <i class="icon-submenu ti-angle-left"></i>
                        </a>
                        <div id="encuestas" class="collapse ">
                            <ul class="submenu">
                                <li><a href="crearEncuesta" id="li_crearEncuesta">Crear Encuesta</a></li>
                                <li><a href="listaEncuesta" id="li_listaEncuesta">Lista de Encuestas</a></li>
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
    @RenderSection("scripts", required:=False)
</body>
</html>
