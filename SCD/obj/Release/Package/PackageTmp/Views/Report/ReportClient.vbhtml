
@Code
    Layout = "~/Views/Template/Index.vbhtml"

End Code

<div class="content-heading clearfix">
    <div class="heading-left">
        <h1 class="page-title">Pacientes</h1>
        <p class="page-subtitle">Reportes</p>
    </div>
</div>

<div class="container-fluid">
    <div class="row sortable-grid">
        <div class="col-md-12 sortable-item">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">Filtros</h3>
                </div>
                <div class="panel-body">
                    <div class="col-md-2">
                        <label>Intervalo de Fechas</label>
                    </div>
                    <div class="col-md-4">
                        <div class="input-daterange input-group" data-provide="datepicker">
                            <input type="text" class="input-sm form-control" name="start" id="dateStart">
                            <span class="input-group-addon">Hasta</span>
                            <input type="text" class="input-sm form-control" name="end" id="dateEnd">
                        </div>
                    </div>
                    <div class="col-md-2">
                        <button type="button" id ="btnFiltrar" class="btn btn-warning"><i class="fa fa-filter"></i> Filtrar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row sortable-grid">
        <div class="col-md-6 sortable-item">
            <!-- CUSTOMER DEMOGRAPHIC -->
            <div class="panel panel-sidebar sidebar-right">
                <div class="panel-heading">
                    <h3 class="panel-title">Pagos por Paciente</h3>
                </div>
                <div class="panel-body">
                    <table class="table table-minimal" id="table-pagos-pacientes">
                        <thead>
                            <tr>
                                <th>NOMBRE</th>
                                <th>APELLIDO</th>
                                <th>DNI</th>
                                <th>TELEFONO</th>
                                <th>PAGO</th>
                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
            </div>
            <!-- END CUSTOMER DEMOGRAPHIC -->
        </div>
        <div class="col-md-6 sortable-item">
            <!-- CUSTOMER DEMOGRAPHIC -->
            <div class="panel panel-sidebar sidebar-right">
                <div class="panel-heading">
                    <h3 class="panel-title">Reporte Gráfico</h3>
                </div>
                <div class="panel-body">
                    <div id="chartdiv" style=";width:  100%;height: 300px;"></div>
                </div>
            </div>
            <!-- END CUSTOMER DEMOGRAPHIC -->
        </div>
    </div>
</div>



    
