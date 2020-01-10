<!-- default file list -->
*Files to look at*:
* [Viewer.aspx](./CS/DXWebApplication1/Viewer.aspx)
<!-- default file list end -->

## How to Customize the Web Document Viewer's Toolbar

This example demonstrates how to handle the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientWebDocumentViewer.CustomizeMenuActions) event to hide the existing **Highlight Editing Fields** toolbar command and add a new **Run Slide Show** command that navigates through pages. 

To get a command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)) method  and pass the command ID as a parameter. To hide a command and its toolbar button, set the command's **visible** property to **false**.

To add a new toolbar command, perform the following steps:
- create an image template (in this example, id = "slideshow")
- specify all command settings including the
 ```imageTemplateName: "slideshow";```
- call the **push** method to add a command to the event argument's **Actions** collection. 

**See also:**

* [Customize the Document Viewer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/117150/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/10043/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400270/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
