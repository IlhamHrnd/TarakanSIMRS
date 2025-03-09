using System.Drawing;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Custom
{
    public class HealthRecord
    {
        private readonly IMergeBilling _mergeBilling;
        public HealthRecord(IMergeBilling mergeBilling)
        {
            _mergeBilling = mergeBilling;
        }

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
                "transfer" => EmrTransferStatus(reg.IsAlreadyTransfer ?? false, reg.TransferNo),
                _ => string.Empty
            };
        }

        [Obsolete]
        public static string StateEmrListObsolte(RegistrationDto reg, string statType)
        {
            return statType switch
            {
                "plafond" => EmrPlafondProgress(reg.RegistrationNo, false),
                "plafondt" => EmrPlafondProgress(reg.RegistrationNo, true),
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
            string icon = reg.IsDoctorOnDuty ?? false ? "<i class=\"fa-solid fa-user-doctor\"></i>" : "<i class=\"fa-solid fa-note-sticky\"></i>";
            return $"<a href=\"#\" onclick=\"javascript:gotoAddUrl('{reg.SRRegistrationType}', '{reg.RegistrationNo}', '{reg.ParamedicID}', '{reg.ServiceUnitID}', '{reg.RoomID}', '{reg.PatientID}', '{reg.IsDoctorOnDuty}'); return false;\" title=\"{title}\">{icon}</a>";
        }

        private static string EmrPatientName(RegistrationDto reg)
        {
            return $"<a href=\"#\" onclick=\"javascript:gotoAddUrl('{reg.SRRegistrationType}', '{reg.RegistrationNo}', '{reg.ParamedicID}', '{reg.ServiceUnitID}', '{reg.RoomID}', '{reg.PatientID}', '{reg.IsDoctorOnDuty}'); return false;\"><strong>{reg.PatientName}</strong><br>{Converter.GetAgeInYear(reg.DateOfBirth)}Y {Converter.GetAgeInMonth(reg.DateOfBirth)}M {Converter.GetAgeInDay(reg.DateOfBirth)}D <br>{reg.GuarantorName}</a>";
        }

        private static string EmrTransferStatus(bool isAlreadyTransfer, string transferNo)
        {
            return EntitySpaces.Generated.Registration.RegistrationTransferStatus(isAlreadyTransfer, transferNo);
        }

        [Obsolete]
        private static string EmrPlafondProgress(string regNo, bool isModeText)
        {
            return EntitySpaces.Generated.MergeBilling.PlafondProgress(regNo, isModeText);
        }
        #endregion
    }
}
