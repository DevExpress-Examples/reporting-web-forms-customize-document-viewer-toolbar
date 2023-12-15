Imports System
Imports System.IO
Imports System.Web
Imports DevExpress.XtraReports.Web

Namespace DXWebApplication1

    Public Class Global_asax
        Inherits HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Viewer.aspx")
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
            WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1(Path.Combine(HttpRuntime.AppDomainAppPath, "Reports")))
            Call ASPxReportDesigner.StaticInitialize()
        End Sub
    End Class
End Namespace
