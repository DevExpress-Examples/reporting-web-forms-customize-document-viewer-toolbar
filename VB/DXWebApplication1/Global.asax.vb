Imports System
Imports System.IO
Imports System.Web
Imports DevExpress.XtraReports.Web

Namespace DXWebApplication1
    Public Class Global_asax
        Inherits System.Web.HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            System.Web.Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Default.aspx")
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1(Path.Combine(HttpRuntime.AppDomainAppPath, "Reports")))
            ASPxReportDesigner.StaticInitialize()
        End Sub
    End Class
End Namespace