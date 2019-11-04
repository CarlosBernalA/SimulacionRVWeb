
Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Function Home() As ActionResult
        Return View()
    End Function

    Function Login() As ActionResult
        Return View()
    End Function

    Function Error404() As ActionResult
        Return View()
    End Function
End Class
