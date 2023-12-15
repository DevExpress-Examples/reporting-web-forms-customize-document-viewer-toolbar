Imports DevExpress.XtraReports.Services
Imports DevExpress.XtraReports.UI
Imports System
Imports System.IO
Imports System.ServiceModel

Namespace DXWebApplication1

    Public Class CustomReportProvider
        Implements IReportProvider

        Protected Property ReportDirectory As String

        Const REPORT_FILE_EXTENSION As String = ".repx"

        Public Sub New(ByVal reportDirectory As String)
            Me.ReportDirectory = reportDirectory
        End Sub

        Public Function GetReport(ByVal id As String, ByVal context As ReportProviderContext) As XtraReport Implements IReportProvider.GetReport
            Try
                Dim reportBytes = File.ReadAllBytes(Path.Combine(ReportDirectory, id & REPORT_FILE_EXTENSION))
                Using memoryStream = New MemoryStream(reportBytes)
                    Return XtraReport.FromStream(memoryStream)
                End Using
            Catch __unusedException1__ As Exception
                Throw New FaultException(New FaultReason(String.Format("Could not find report '{0}'.", id)), New FaultCode("Server"), "GetReport")
            End Try
        End Function
    End Class
End Namespace
