Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="login",
            url:="login",
            defaults:=New With {.controller = "Home", .action = "Login"}
        )

        routes.MapRoute(
            name:="local",
            url:="local",
            defaults:=New With {.controller = "Local", .action = "Local"}
        )

        routes.MapRoute(
            name:="rol",
            url:="rol",
            defaults:=New With {.controller = "AsignacionRol", .action = "Rol"}
        )

        routes.MapRoute(
            name:="area",
            url:="area",
            defaults:=New With {.controller = "Area", .action = "Area"}
        )

        routes.MapRoute(
            name:="programa",
            url:="programa",
            defaults:=New With {.controller = "Programa", .action = "Programa"}
        )

        routes.MapRoute(
            name:="trabajador",
            url:="trabajador",
            defaults:=New With {.controller = "Trabajador", .action = "Trabajador"}
        )

        routes.MapRoute(
            name:="asignacionrol",
            url:="asignacionrol",
            defaults:=New With {.controller = "AsignacionRol", .action = "AsignacionRol"}
        )

        routes.MapRoute(
            name:="principal",
            url:="principal",
            defaults:=New With {.controller = "Home", .action = "Home"}
        )

        routes.MapRoute(
            name:="simulacion",
            url:="simulacion",
            defaults:=New With {.controller = "Simulacion", .action = "Simulacion"}
        )

        routes.MapRoute(
            name:="tiposimulacion",
            url:="tiposimulacion",
            defaults:=New With {.controller = "Simulacion", .action = "TipoSimulacion"}
        )

        routes.MapRoute(
            name:="",
            url:="",
            defaults:=New With {.controller = "Home", .action = "Login"}
        )

        'routes.MapRoute(
        'name:="Default",
        'url:="{controller}/{action}/{id}",
        'defaults:=New With {.controller = "Home", .action = "Login", .id = UrlParameter.Optional}
        ')

        routes.MapRoute(
               name:="NotFound",
               url:="{*url}",
               defaults:=New With {.controller = "Home", .action = "Error404"}
        )


    End Sub
End Module