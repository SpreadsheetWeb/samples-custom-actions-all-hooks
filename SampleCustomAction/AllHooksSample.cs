using Pagos.Designer.Interfaces.External.CustomHooks;
using Pagos.Designer.Interfaces.External.DataTransfer;
using Pagos.Designer.Interfaces.External.Messaging;
using Pagos.SpreadsheetWeb.Web.Api.Objects.ApplicationSchema;
using Pagos.SpreadsheetWeb.Web.Api.Objects.Email;

namespace SampleCustomAction
{
    public class AllHooksSample : 
        IAfterCalculation, 
        IAfterAllCalculations, 
        IAfterEmail, 
        IAfterExcelExport, 
        IAfterPrint, 
        IAfterSave, 
        IBeforeAllCalculations, 
        IBeforeCalculation, 
        IBeforeEmail, 
        IBeforeExcelExport, 
        IBeforePrint, 
        IBeforeSave
    
    {
        public ActionableResponse AfterAllCalculations(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse AfterCalculation(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public StandardResponse AfterEmail(INamedRangesCache namedRangesCache, EmailResponse emailResponse)
        {
            return new StandardResponse()
            {
                Success = true
            };
        }

        public StandardResponse AfterExcelExport(INamedRangesCache namedRangesCache, ExcelExportOutput excelExportOutput)
        {
            return new StandardResponse()
            {
                Success = true
            };
        }

        public StandardResponse AfterPrint(INamedRangesCache namedRangesCache, PrintProcessOutput printProcessOutput)
        {
            return new StandardResponse()
            {
                Success = true
            };
        }

        public ActionableResponse AfterSave(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforeAllCalculations(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforeCalculation(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforeEmail(INamedRangesCache namedRangesCache, EmailRequest emailRequest)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforeExcelExport(INamedRangesCache namedRangesCache, ExcelExportInfo excelExportInfo)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforePrint(INamedRangesCache namedRangesCache, PrintProcessInfo printProcessInfo)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }

        public ActionableResponse BeforeSave(INamedRangesCache namedRangesCache)
        {
            return new ActionableResponse()
            {
                Success = true
            };
        }
    }
}
