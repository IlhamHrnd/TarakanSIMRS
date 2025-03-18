using System.Drawing;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;

namespace Tarakan.BusinessObjects.Custom
{
    public class Integrated
    {
        #region Custom View
        public static string GetColorOfUserType(string srUserType)
        {
            Color color;
            color = srUserType switch
            {
                "DTR" => Color.LightGreen,
                "NRS" => Color.Blue,
                "FAR" => Color.Yellow,
                "NUT" => Color.Green,
                "RHB" => Color.Red,
                "TGM" => Color.LightPink,
                _ => Color.White,
            };
            return color.Name;
        }
        #endregion

        #region Button
        public static bool IntegratedNoteDeleteAble(RegistrationInfoMedicDto rim, string userId)
        {
            return Const.MedicalNotes.Contains(rim.SrmedicalNotesInputType) && rim.IsDeleted == false && rim.IsApproved == false && rim.CreatedByUserId == userId 
                && rim.SRNursingDiagnosaLevel != "40";
        }

        public static bool IntegratedNoteUnDeleteAble(RegistrationInfoMedicDto rim, string userId)
        {
            return Const.MedicalNotes.Contains(rim.SrmedicalNotesInputType) && rim.IsDeleted == true && rim.CreatedByUserId == userId && rim.SRNursingDiagnosaLevel != "40";
        }

        public static bool IsAccessVerif(RegistrationInfoMedicDto rim, string parId, string srUserType, bool isUserParamedicDpjp)
        {
            return !string.IsNullOrEmpty(parId) && srUserType == Const.Doctor && Const.MedicalNotes3.Contains(rim.SrmedicalNotesInputType) && string.IsNullOrEmpty(rim.AssessmentTypeName) && rim.IsDeleted == false
                && rim.IsApproved == false && (isUserParamedicDpjp || parId == rim.ParamedicId);
        }

        public static bool IsEditable(bool isApprove, string createdUserId, string userId)
        {
            return isApprove == false && createdUserId == userId;
        }

        public static string IntegratedNoteDelete(string rimId, bool isFromAskep)
        {
            return $"<a href=\"#\" onclick=\"javascript:onDeleteIntegratedNote('{rimId}', '{isFromAskep}'); return false;\" alt=\"Void\" title=\"Void\"><i class=\"fa-solid fa-trash\"></i></a>";
        }

        public static string IntegratedNoteUnDelete(string rimId, bool isFromAskep)
        {
            return $"<a href=\"#\" onclick=\"javascript:onUnDeleteIntegratedNote('{rimId}', '{isFromAskep}'); return false;\" alt=\"Unvoid\" title=\"Unvoid\"><i class=\"fa-solid fa-retweet\"></i></a>";
        }

        public static string IntegratedNotePrint(bool isDeleted, string srMedicalType, bool isFromAskep, string rimId)
        {
            if (isDeleted)
                return string.Empty;

            return Const.MedicalNotes2.Contains(srMedicalType) && isFromAskep == false && isDeleted == false
                ? "<a href=\"#\" onclick=\"javascript:printPreviewIntegratedNotes('{0}'); return false;\" alt=\"Print Integrated Notes\" title=\"Print Integrated Notes\"><i class=\"fa-solid fa-print\"></i></a><br /><br />"
                : string.Empty;
        }

        public static string IntegratedNoteVerif(RegistrationInfoMedicDto rim, bool isUserParamedicDpjp, string parId, string srUserType)
        {
            if (IsAccessVerif(rim, parId, srUserType, isUserParamedicDpjp))
                return $"<a style=\"cursor:pointer;\" onclick=\"javascript:openCpptVerification('{rim.RegistrationInfoMedicId}_{rim.IsFromAskep}','{rim.ParamedicId}','{isUserParamedicDpjp}')\" alt=\"Verification Integrated Notes\" title=\"Verification Integrated Notes\"><i class=\"fa-solid fa-circle-check\"></i></a><br /><br />";
            else
                return string.Empty;
        }

        public static string IntegratedEntryAssessment(RegistrationInfoMedicDto rim, string userId)
        {
            string mode = IsEditable(rim.IsApproved ?? false, rim.CreatedByUserId, userId) ? "edit" : "view";
            string icon = IsEditable(rim.IsApproved ?? false, rim.CreatedByUserId, userId) ? "<i class=\"fa-solid fa-pen-to-square\"></i>" : "<i class=\"fa-solid fa-folder-open\"></i>";
            return $"<a href=\"#\" onclick=\"javascript:entryAssessment('{mode}', '{rim.RegistrationNo}', '{rim.ServiceUnitId}','{rim.SRAssessmentType}','{rim.RegistrationInfoMedicId}','{rim.IsInitialAssessment}','{rim.SrmedicalNotesInputType}','{rim.ReferenceNo}','{rim.FromRegistrationNo}','{rim.ParamedicId}'); return false;\" alt=\"{mode}\" title=\"{mode}\">{icon}</a><br /><br />";
        }
        #endregion
    }
}
