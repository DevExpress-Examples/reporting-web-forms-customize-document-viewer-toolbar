<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.cs" Inherits="DXWebApplication1.Viewer" %>

<%@ Register Assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/html" id="slideshow">
        <svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 24 24" style="enable-background: new 0 0 24 24;" xml:space="preserve">
            <polygon class="dxd-icon-fill" points="4,2 4,22 22,12 " />
        </svg>
    </script>
    <script type="text/javascript">
        function customizeMenuAction(s, e) {
            var interval;
            var selected = ko.observable(false);
            e.Actions.push({
                text: "Run Slide Show",
                imageTemplateName: "slideshow",
                visible: true,
                disabled: false,
                selected: selected,
                clickAction: function () {
                    if (selected()) {
                        clearInterval(interval);
                        selected(false);
                        return;
                    }
                    var model = s.GetPreviewModel();
                    if (model) {
                        selected(true);
                        interval = setInterval(function () {
                            var pageIndex = model.GetCurrentPageIndex();
                            model.GoToPage(pageIndex + 1);
                        }, 2000);
                    }
                }
            });

            var highlightEditingFieldsAction = e.GetById(DevExpress.Report.Preview.ActionId.HighlightEditingFields);
            if (highlightEditingFieldsAction)
                highlightEditingFieldsAction.visible = false;
        }
    </script>
    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
        <ClientSideEvents CustomizeMenuActions="customizeMenuAction" />
    </dx:ASPxWebDocumentViewer>
</asp:Content>
