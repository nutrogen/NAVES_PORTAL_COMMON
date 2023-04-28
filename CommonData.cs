using Microsoft.Build.Evaluation;
using NavesPortalforWebWithCoreMvc.ViewModels;
using Syncfusion.EJ2.Inputs;
using System.Security.Policy;

namespace NavesPortalforWebWithCoreMvc.Common
{
    public static class CommonSettingData
    {
        public enum LogStatus
        {
            CREATE,
            DELETE,
            MODIFY,
            SUBMIT,
            CONFIRM
        }

        public enum ProjectConfirmFromPM
        {
            CONFIRM,
            REJECT
        }


        public enum CreateDsrStatus
        {
            NEW,
            SAVED,
            SUBMIT,
            CONFIRM
        }

        public enum ProjectID_Status
        {
            DRAFT,
            SUBMIT,
            CONFIRM,
            ARRANGEMENT,
            INPROGRESS,
            COMPLETE,
            CANCEL,
            REJECTED,
        }

        /// <summary>
        /// SIP, CAP
        /// </summary>
        public enum WrokId_Status_Case_SIP_CAP
        {
            DRAFT,
            SUBMIT,
            CONFIRM,
            ARRANGEMENT,
            PLAN,
            ONSURVEY,
            INSPECTED,
            REPORTSUBMIT,
            VERIFIED,
            FINALSUBMIT,
            FINALVERIFIED,
            COMPLETE
        }

        /// <summary>
        /// NBM
        /// </summary>
        public enum WrokId_Status_Case_NBM
        {
            DRAFT,
            SUBMIT,
            CONFIRM,
            ARRANGEMENT,
            PLAN,
            ONSURVEY,
            INSPECTED,
            FINALSUBMIT,
            FINALVERIFIED,
            COMPLETE
        }

        /// <summary>
        /// DIS, MRO
        /// </summary>
        public enum WrokId_Status_Case_DIS_MRO
        {
            DRAFT,
            SUBMIT,
            CONFIRM,
            ARRANGEMENT,
            PLAN,
            ONSURVEY,
            INSPECTED,
            FINALSUBMIT,
            FINALVERIFIED,
            COMPLETE
        }

        public enum Dis_Itp_Status
        {
            NEW,
            SUBMIT,
            CONFIRM
        }

        public enum Dis_Revision_Status
        {
            ORIGINAL,
            ADD,
            DELETE
        }

        public enum Dis_Action_Status
        {
            REVISION,
            APPLY
        }

        public enum Mro_Planning_Status
        {
            SAVED,
            SUBMIT,
            CONFIRM
        }

        public static string[] getBasicRichTextEditorFullItemLists()
        {
            return new[] {
                "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase","SuperScript", "SubScript", "|",
                "Formats", "Alignments", "OrderedList", "UnorderedList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
        }


        /// <summary>
        /// RichiText Editor Item 기본 Item
        /// </summary>
        /// <returns></returns>
        public static string[] getBasicRichTextEditorItemLists()
        {
            return new[] {
                "Bold", "Italic", "Underline", "StrikeThrough","FontName", "FontSize", "FontColor", "BackgroundColor","LowerCase", "UpperCase", "|",
                "Formats", "Alignments", "OrderedList", "UnorderedList","Outdent", "Indent", "|",
                "ClearFormat", "SourceCode", "FullScreen","|",
                "Undo", "Redo" };
        }

        /// <summary>
        /// RichiText Editor Modal 기본 Item
        /// </summary>
        /// <returns></returns>
        public static string[] getModalRichTextEditorItemLists()
        {
            return new[] {
                "Bold", "Italic", "Underline", "StrikeThrough","FontName", "FontSize", "FontColor", "BackgroundColor", "|",
                "Formats", "Alignments" };
        }

        public static string[] getModalRichTextEditorImageToolBars()
        {
            return new[] {
                "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
                "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"};
        }

        //public static string[] getRichTextEditorFileManager()
        //{
        //    https://ej2.syncfusion.com/aspnetcore/RichTextEditor/IFrame#/bootstrap5
        //    string hostUrl = "https://ej2-aspcore-service.azurewebsites.net/";

        //    return new[] {
        //        url = hostUrl + "api/FileManager/FileOperations",
        //        getImageUrl = hostUrl + "api/FileManager/GetImage",
        //        uploadUrl = hostUrl + "api/FileManager/Upload",
        //        downloadUrl = hostUrl + "api/FileManager/Download"
        //    };
        //}




        public static List<DropDownListViewModel> GetPlatformType()
        {
            List<DropDownListViewModel> _ProjectType = new List<DropDownListViewModel>();
            _ProjectType.Add(new DropDownListViewModel { Text = "N-NBM", Value = "NBM" });
            _ProjectType.Add(new DropDownListViewModel { Text = "ENG", Value = "ENG" });
            _ProjectType.Add(new DropDownListViewModel { Text = "MRO", Value = "MRO" });
            _ProjectType.Add(new DropDownListViewModel { Text = "DIS", Value = "DIS" });
            _ProjectType.Add(new DropDownListViewModel { Text = "SIP", Value = "SIP" });
            _ProjectType.Add(new DropDownListViewModel { Text = "N/P/SS-CAP", Value = "CAP" });
            _ProjectType.Add(new DropDownListViewModel { Text = "EQI", Value = "EQI" });
            _ProjectType.Add(new DropDownListViewModel { Text = "NSS", Value = "NSS" });

            return _ProjectType;
        }


        public static List<DropDownListViewModel> GetCurrencyType()
        {
            List<DropDownListViewModel> _CurrnecyType = new List<DropDownListViewModel>();
            _CurrnecyType.Add(new DropDownListViewModel { Text = "$ (USD)", Value = "$" });
            _CurrnecyType.Add(new DropDownListViewModel { Text = "₩ (KRW)", Value = "₩" });
            _CurrnecyType.Add(new DropDownListViewModel { Text = "€ (EUR)", Value = "€" });

            return _CurrnecyType;
        }

        public static List<DropDownListViewModel> GetUnit()
        {
            List<DropDownListViewModel> _Unit = new List<DropDownListViewModel>();
            _Unit.Add(new DropDownListViewModel { Text = "Set", Value = "Set" });
            _Unit.Add(new DropDownListViewModel { Text = "Unit", Value = "Unit" });
            _Unit.Add(new DropDownListViewModel { Text = "EA", Value = "EA" });
            _Unit.Add(new DropDownListViewModel { Text = "PCS", Value = "PCS" });

            return _Unit;
        }

        public static List<DropDownListViewModel> GetUsedVehicle()
        {
            List<DropDownListViewModel> _UsedVehicle = new List<DropDownListViewModel>();
            _UsedVehicle.Add(new DropDownListViewModel { Text = "N/A", Value = "X" });
            _UsedVehicle.Add(new DropDownListViewModel { Text = "My Car", Value = "M" });
            _UsedVehicle.Add(new DropDownListViewModel { Text = "Rent", Value = "R" });
            _UsedVehicle.Add(new DropDownListViewModel { Text = "KR Car", Value = "K" });

            return _UsedVehicle;
        }

        public static List<DropDownListViewModel> GetHours()
        {
            List<DropDownListViewModel> ReportingTimeHour = new List<DropDownListViewModel>();
            for (int i = 0; i <= 23; i++)
            {
                ReportingTimeHour.Add(new DropDownListViewModel { Text = i.ToString(), Value = i.ToString() });
            }

            return ReportingTimeHour;
        }

        public static List<DropDownListViewModel> GetMinutes()
        {
            List<DropDownListViewModel> ReportingTimeMinute = new List<DropDownListViewModel>();
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "00", Value = "00" });
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "10", Value = "10" });
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "20", Value = "20" });
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "30", Value = "30" });
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "40", Value = "40" });
            ReportingTimeMinute.Add(new DropDownListViewModel { Text = "50", Value = "50" });

            return ReportingTimeMinute;
        }

        public static List<DropDownListViewModel> GetResponsible()
        {
            List<DropDownListViewModel> Responsible = new List<DropDownListViewModel>();
            Responsible.Add(new DropDownListViewModel { Text = "Owner", Value = "OWNER" });
            Responsible.Add(new DropDownListViewModel { Text = "DtaQ", Value = "DTAQ" });
            Responsible.Add(new DropDownListViewModel { Text = "DAPA", Value = "DAPA" });
            Responsible.Add(new DropDownListViewModel { Text = "KR", Value = "KR" });
            Responsible.Add(new DropDownListViewModel { Text = "Mfr", Value = "MFR" });
            Responsible.Add(new DropDownListViewModel { Text = "Shipyard", Value = "SHIPYARD" });
            Responsible.Add(new DropDownListViewModel { Text = "QA/QC", Value = "QAQC" });

            return Responsible;
        }

        public static List<DropDownListViewModel> GetLegend()
        {
            List<DropDownListViewModel> Legend = new List<DropDownListViewModel>();
            Legend.Add(new DropDownListViewModel { Text = "S: Submit", Value = "SUBMIT" });
            Legend.Add(new DropDownListViewModel { Text = "A: Approval", Value = "APPROVAL" });
            Legend.Add(new DropDownListViewModel { Text = "I: Inform", Value = "INFORM" });
            Legend.Add(new DropDownListViewModel { Text = "R: Review", Value = "REVIEW" });
            Legend.Add(new DropDownListViewModel { Text = "M: Monitoring", Value = "MONITORING" });
            Legend.Add(new DropDownListViewModel { Text = "S/W: Spot Witness", Value = "SPOT_WITNESS" });
            Legend.Add(new DropDownListViewModel { Text = "W: Witness", Value = "WITNESS" });
            Legend.Add(new DropDownListViewModel { Text = "H: Hold Point", Value = "HOLD_POINT" });

            return Legend;
        }

        public static List<DropDownListViewModel> GetDepartmentList()
        {
            List<DropDownListViewModel> departments = new List<DropDownListViewModel>();
            departments.Add(new DropDownListViewModel { Text = "Naval Business Planning Team", Value = "NVP" });
            departments.Add(new DropDownListViewModel { Text = "Naval Vessel Survey Team", Value = "NVS" });
            departments.Add(new DropDownListViewModel { Text = "Naval Vessel Technology Team", Value = "NVT" });

            return departments;
        }

        public static List<DropDownListViewModel> GetClientNameList()
        {
            List<DropDownListViewModel> clientName = new List<DropDownListViewModel>();
            clientName.Add(new DropDownListViewModel { Text = "Republic of Korea Navy Headquarters (해군본부)", Value = "Republic of Korea Navy Headquarters (해군본부)" });
            clientName.Add(new DropDownListViewModel { Text = "Naval Logistics Command (해군군수사령부)", Value = "Naval Logistics Command (해군군수사령부)" });
            clientName.Add(new DropDownListViewModel { Text = "Korea Coast Guard (해양경찰청)", Value = "Korea Coast Guard (해양경찰청)" });
            clientName.Add(new DropDownListViewModel { Text = "Korea Coast Guard Shipyard (해양경찰정비창)", Value = "Korea Coast Guard Shipyard (해양경찰정비창)" });
            clientName.Add(new DropDownListViewModel { Text = "Defense Acquisition Program Administration (방위사업청)", Value = "Defense Acquisition Program Administration (방위사업청)" });
            clientName.Add(new DropDownListViewModel { Text = "Hyundai Heavy Industries Co., Ltd. (현대중공업㈜)", Value = "Hyundai Heavy Industries Co., Ltd. (현대중공업㈜)" });
            clientName.Add(new DropDownListViewModel { Text = "Daewoo Shipbuilding & Marine Engineering Co., Ltd. (대우조선해양㈜)", Value = "Daewoo Shipbuilding & Marine Engineering Co., Ltd. (대우조선해양㈜)" });
            clientName.Add(new DropDownListViewModel { Text = "HJ Shipbuilding & Construction Co., Ltd. (㈜HJ중공업)", Value = "HJ Shipbuilding & Construction Co., Ltd. (㈜HJ중공업)" });
            clientName.Add(new DropDownListViewModel { Text = "Samkang M&T Co., Ltd. (삼강엠앤티㈜)", Value = "Samkang M&T Co., Ltd. (삼강엠앤티㈜)" });
            clientName.Add(new DropDownListViewModel { Text = "Kangnam Corporation (㈜강남)", Value = "Kangnam Corporation (㈜강남)" });

            return clientName;
        }
    }
}
