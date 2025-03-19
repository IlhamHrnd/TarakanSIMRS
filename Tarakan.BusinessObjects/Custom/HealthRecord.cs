using System.Drawing;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.EntitySpaces.Generated;

namespace Tarakan.BusinessObjects.Custom
{
    public class HealthRecord
    {
        #region Custom View
        public static string GetColorOfTriase(string SRTriage)
        {
            Color color;
            color = SRTriage switch
            {
                "01" => Color.Red,
                "02" => Color.Yellow,
                "03" => Color.Yellow,
                "04" => Color.Green,
                "05" => Color.Black,
                "99" => Color.Blue,
                _ => Color.White,
            };
            return color.Name;
        }

        public static string StateEMRList(RegistrationDto reg, string statType)
        {
            return statType switch
            {
                "title" => EmrTitle(reg.Group, reg.ParamedicName),
                "detail" => EmrDetail(reg),
                "name" => EmrPatientName(reg),
                "transfer" => Registration.RegistrationTransferStatus(reg.IsAlreadyTransfer ?? false, reg.TransferNo),
                "confirm" => EmrConfirmedAttendance(reg.SRRegistrationType, reg.IsConfirmedAttendance ?? false, reg.RegistrationNo),
                "finish" => EmrFinishedAttendance(reg.SRRegistrationType, reg.IsFinishedAttendance, reg.RegistrationNo),
                "note" => RegistrationInfoSumary.RegistrationNoteCount(reg.RegistrationNo),
                "medication" => EmrPrescription(reg.RegistrationNo, reg.PatientID),
                "history" => EmrMedicationHistory(reg.SRRegistrationType, reg.PatientID, reg.RegistrationNo, reg.FromRegistrationNo),
                "print" => EmrPrint(reg.RegistrationNo),
                "physician" => EmrPhysician(reg.IsParamedicNotNull, reg.SRRegistrationType, reg.RegistrationNo, reg.ServiceUnitID),
                "risk" => EmrRiskStatus(reg.RegistrationNo, reg.SRPatientRiskStatus),
                _ => string.Empty
            };
        }

        [Obsolete]
        public static string StateEmrListObsolte(RegistrationDto reg, string statType)
        {
            return statType switch
            {
                "plafond" => MergeBilling.PlafondProgress(reg.RegistrationNo, false),
                "plafondt" => MergeBilling.PlafondProgress(reg.RegistrationNo, true),
                "soap" => Registration.SoapEntryStatus(reg.RegistrationNo, reg.ParamedicID, reg.SRRegistrationType),
                _ => string.Empty
            };
        }

        private static string EmrTitle(string serviceunitName, string paramedicName)
        {
            return $"Service Unit: <b>{serviceunitName}</b><br/>&nbsp;&nbsp;Reg To: <b>{paramedicName}</b>";
        }

        private static string EmrDetail(RegistrationDto reg)
        {
            string title = reg.IsDoctorOnDuty ?? false ? "Doctor required" : "New";
            string icon = reg.IsDoctorOnDuty ?? false ? $"<i class=\"{BaseIcon.Doctor}\"></i>" : $"<i class=\"{BaseIcon.Note}\"></i>";
            return $"<a href=\"#\" onclick=\"javascript:gotoAddUrl('{reg.SRRegistrationType}', '{reg.RegistrationNo}', '{reg.ParamedicID}', '{reg.ServiceUnitID}', '{reg.RoomID}', '{reg.PatientID}', '{reg.IsDoctorOnDuty}'); return false;\" title=\"{title}\">{icon}</a>";
        }

        private static string EmrPatientName(RegistrationDto reg)
        {
            return $"<a href=\"#\" onclick=\"javascript:gotoAddUrl('{reg.SRRegistrationType}', '{reg.RegistrationNo}', '{reg.ParamedicID}', '{reg.ServiceUnitID}', '{reg.RoomID}', '{reg.PatientID}', '{reg.IsDoctorOnDuty}'); return false;\"><strong>{reg.PatientName}</strong><br>{Converter.GetAgeInYear(reg.DateOfBirth)}Y {Converter.GetAgeInMonth(reg.DateOfBirth)}M {Converter.GetAgeInDay(reg.DateOfBirth)}D <br>{reg.GuarantorName}</a>";
        }

        private static string EmrConfirmedAttendance(string regType, bool isConfirmedAttendance, string regNo)
        {
            if (regType == Const.Inpatient)
                return string.Empty;

            return isConfirmedAttendance
                ? $"<i class=\"{BaseIcon.Checkcircle} {BaseIcon.Secondary}\" alt=\"Confirmed\" title=\"Confirmed\"></i>"
                : $"<i class=\"{BaseIcon.Checkcircle} {BaseIcon.Danger}\" onclick=\"regConfirmed('{regNo}'); return false;\" alt=\"Confirmed\" title=\"Confirmed Attendance\"></i>";
        }

        private static string EmrFinishedAttendance(string regType, bool isFinisheddAttendance, string regNo)
        {
            if (regType == Const.Inpatient)
                return string.Empty;

            return isFinisheddAttendance
                ? $"<i class=\"{BaseIcon.Checkcircle} {BaseIcon.Secondary}\" alt=\"Finished\" title=\"Finished\"></i>"
                : $"<i class=\"{BaseIcon.Checkcircle} {BaseIcon.Success}\" onclick=\"regFinished('{regNo}'); return false;\" alt=\"Finished\" title=\"Finished Attendance\"></i>";
        }

        private static string EmrPrescription(string regNo, string patId)
        {
            return $"<a href=\"#\" class=\"icon\" onclick=\"openMedicationReceiveOpt('{regNo}','{patId}'); return false;\" alt=\"Medication Menu\" title=\"Medication Menu\"><i class=\"{BaseIcon.Capsule} text-info\"></i></a>";
        }

        private static string EmrMedicationHistory(string regType, string patId, string regNo, string fromRegNo)
        {
            return regType != Const.Inpatient
                ? string.Empty
                : $"<a href=\"#\" onclick=\"openMedicationHist('{patId}','{regNo}','{fromRegNo}'); return false;\" alt=\"Medication History\" title=\"Medication History\"><i class=\"{BaseIcon.Laptop}\"></i></a>";
        }
        
        private static string EmrPrint(string regNo)
        {
            return $"<a href=\"#\" onclick=\"openPrintDialog('{regNo}'); return false;\" alt=\"Print\" title=\"Print\"><i class=\"{BaseIcon.Print}\"></i></a>";
        }

        private static string EmrPhysician(bool isParamedicNotNull, string regType, string regNo, string suId)
        {
            return isParamedicNotNull
                ? string.Empty
                : $"<a href=\"#\" onclick=\"onEditPhysician('{regType}', '{regNo}', '{suId}'); return false;\"><i class=\"{BaseIcon.Doctor}\" alt=\"Edit Physician\" title=\"Edit Physician\"></i></a>";
        }

        private static string EmrRiskStatus(string regNo, string srRiskStatus)
        {
            string status = srRiskStatus switch
            {
                "X" => $"<i class=\"{BaseIcon.Personrisk} {BaseIcon.Success}\"></i>",
                "0" => $"<i class=\"{BaseIcon.Personrisk} {BaseIcon.Warning}\"></i>",
                "1" => $"<i class=\"{BaseIcon.Personrisk} {BaseIcon.Danger}\"></i>",
                _ => $"<i class=\"{BaseIcon.Personrisk} {BaseIcon.Secondary}\"></i>",
            };
            return $"<a href=\"#\" onclick=\"openPatientRiskDialog('{regNo}'); return false;\" alt=\"Risk Status\" title=\"Risk Status\">{status}</a>";
        }
        #endregion
    }
}
