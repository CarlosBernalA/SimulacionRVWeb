Imports System.Web.Mvc

Namespace Controllers
    Public Class SimulacionController
        Inherits Controller

        ' GET: Simulacion
        Function Simulacion() As ActionResult
            Return View()
        End Function
        Function TipoSimulacion() As ActionResult
            Return View()
        End Function
    End Class
End Namespace