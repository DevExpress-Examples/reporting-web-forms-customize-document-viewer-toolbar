<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/167319057/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830473)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for Web Forms - How to Customize the Web Document Viewer's Toolbar

This example shows how to handle the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientWebDocumentViewer.CustomizeMenuActions) event to hide the existing **Highlight Editing Fields** toolbar command and add a new **Run Slide Show** command that navigates through pages. 

To get a command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)) method  and pass the command ID as a parameter. To hide a command and its toolbar button, set the command's `visible` property to `false`.

To add a new toolbar command, follow the steps below:
- create an image template (in this example, id = "slideshow")
- specify all command settings including the
 ```imageTemplateName: "slideshow";```
- call the **push** method to add a command to the event argument's **Actions** collection. 

## Files to Review

* [Viewer.aspx](./CS/DXWebApplication1/Viewer.aspx)

## Documentation

* [Customize the Document Viewer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/117150/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/10043/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/document-viewer/html5-document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
* [Customize the Document Viewer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400270/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/customize-the-document-viewer-toolbar)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-customize-document-viewer-toolbar&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-customize-document-viewer-toolbar&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
