using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.Web;

namespace DXWebApplication1 {
    public class CustomReportProvider : DevExpress.XtraReports.Services.IReportProvider {
        protected string ReportDirectory { get; set; }
        const string REPORT_FILE_EXTENSION = ".repx";

        public CustomReportProvider(string reportDirectory) {
            this.ReportDirectory = reportDirectory;
        }

        public XtraReport GetReport(string id, ReportProviderContext context) {
            try {
                var reportBytes = File.ReadAllBytes(Path.Combine(ReportDirectory, id + REPORT_FILE_EXTENSION));
                using (var memoryStream = new MemoryStream(reportBytes)) {
                    return XtraReport.FromStream(memoryStream);
                }
            }
            catch (Exception) {
                throw new FaultException(new FaultReason(string.Format("Could not find report '{0}'.", id)), new FaultCode("Server"), "GetReport");
            }
        }
    }
}