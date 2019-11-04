var chart;

$(document).ready(function () {
    dibujar_chart_paciente();

    $('#btnFiltrar').click(function () {
        traer_pago_pacientes();
    });
})

function traer_pago_pacientes() {
    var data = {};
    data.Fecha_Inicio = $('#dateStart').val();
    data.Fecha_Fin = $('#dateEnd').val();

    var array_data = [];
    var array_graphs = [];
    var graphs = [];
    var category = [];
    var data_text = [];

    $.ajax({
        type: "POST",
        url: "Report/Get_Report_Pago_Paciente",
        data: data,
        datatype: "JSON",
        success: function (response) {

            $('#tbody-table-pagos-pacientes').empty();
            var resp = JSON.parse(response);

            $.each(resp, function (i, item) {
                var newRow = $("<tr>");
                var cols = "";

                cols += "  <td>" + item.nombre + "</td>";
                cols += "  <td>" + item.apellido + "</td>";
                cols += "  <td>" + item.dni + "</td>";
                cols += "  <td>" + item.telefono + "</td>";
                cols += "  <td>" + item.Pago + "</td>";

                newRow.append(cols);
                $("#table-pagos-pacientes").append(newRow);

                //if (graphs.indexOf(item.dni) == -1) {

                //    array_graphs.push({
                //        "balloonText": "Pago:[[value]]",
                //        "fillAlphas": 1,
                //        "id": item.dni,
                //        "color": "#0D8ECF",
                //        "labelText": "[[value]]",
                //        "labelOffset": 15,
                //        "type": "column",
                //        "valueField": "column-" + item.dni
                //    });

                //    graphs.push(item.DiagnosticYear);
                //}

                if (category.indexOf(item.dni) == -1) {
                    category.push(item.dni);
                    data_text.push('{ "nombre": "' + item.nombre + '", "pago": "' + item.Pago + '",');
                }

                

            });
        },
        complete: function () {
            for (var i = 0; i < data_text.length; i++) {    
                data_text[i] = data_text[i].slice(0, -1) + "}";
                array_data.push(JSON.parse(data_text[i]));
            }
            //chart.graphs = array_graphs;
            chart.dataProvider = array_data;
            chart.validateData();
        }
    });
}

function dibujar_chart_paciente() {
    chart = AmCharts.makeChart("chartdiv", {
        "type": "serial",
        "theme": "light",
        "marginRight": 70,
        "dataProvider": [],
        "valueAxes": [{
            "axisAlpha": 0,
            "position": "left",
            "title": "Cantidad en Soles"
        }],
        "startDuration": 1,
        "graphs": [{
            "balloonText": "<b>[[category]]: [[value]]</b>",
            "fillColorsField": "#0D8ECF",
            "fillAlphas": 0.9,
            "lineAlpha": 0.2,
            "type": "column",
            "labelText": "[[value]]",
            "labelOffset": 15,
            "valueField": "pago"
        }],
        "chartCursor": {
            "categoryBalloonEnabled": false,
            "cursorAlpha": 0,
            "zoomable": false
        },
        "categoryField": "nombre",
        "categoryAxis": {
            "gridPosition": "start",
            "labelRotation": 45
        },
        "export": {
            "enabled": true
        }

    });
}
