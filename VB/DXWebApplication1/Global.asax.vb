Imports System
Imports System.Web
Imports DevExpress.XtraReports.Services
Imports DevExpress.XtraReports.Web

Namespace DXWebApplication1

    Public Class Global_asax
        Inherits HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
            WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            WebDocumentViewer.DefaultWebDocumentViewerContainer.RegisterSingleton(Of IReportProvider)(New CustomReportProvider(Server.MapPath("~/Reports")))
            Call ASPxReportDesigner.StaticInitialize()
        End Sub
    End Class
End Namespace
