## How to customize the Document Viewer toolbar

This example demonstrates how to use the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientWebDocumentViewer.CustomizeMenuActions) event to hide the existing **Highlight Editing Fields** toolbar command and add a new **Run Slide Show** command that navigates through document pages. 

To obtain the existing command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)) method  and pass the command ID as a parameter. Then, disable the obtained command's **visible** property to hide it.

To add a new toolbar command, specify its [settings](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientMenuAction._members) and push it to the event argument's **Actions** collection. 

See the following documentation topics for more information:

* [Customize the Document Viewer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/117150/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/10043/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400270/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
