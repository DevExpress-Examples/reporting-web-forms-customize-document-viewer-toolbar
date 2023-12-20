using System;
using System.IO;
using System.Web;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web;

namespace DXWebApplication1 {
    public class Global_asax : System.Web.HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;            
            DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.RegisterSingleton<IReportProvider>(new CustomReportProvider(Server.MapPath("~/Reports")));
            ASPxReportDesigner.StaticInitialize();
        }
    }
}