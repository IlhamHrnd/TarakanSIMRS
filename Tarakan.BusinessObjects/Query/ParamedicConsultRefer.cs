using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class ParamedicConsultRefer : IParamedicConsultRefer
    {
        public ParamedicConsultReferDto LoadByPrimaryKey(string refNo)
        {
            if (string.IsNullOrEmpty(refNo))
                return new ParamedicConsultReferDto();

            var pcr = new EntitySpaces.Generated.ParamedicConsultRefer();
            if (!pcr.LoadByPrimaryKey(refNo))
                return new ParamedicConsultReferDto();

            return new ParamedicConsultReferDto
            {
                ConsultReferNo = pcr.ConsultReferNo,
                ConsultDateTime = pcr.ConsultDateTime ?? new DateTime(),
                RegistrationNo = pcr.RegistrationNo,
                ParamedicId = pcr.ParamedicID,
                SrparamedicConsultType = pcr.SRParamedicConsultType,
                ConsultReferType = pcr.ConsultReferType == null ? string.Empty : Convert.ToString(pcr.ConsultReferType),
                ToServiceUnitId = pcr.ToServiceUnitID,
                ToParamedicId = pcr.ToParamedicID,
                ToRoomId = pcr.ToRoomID,
                ToRegistrationQue = pcr.ToRegistrationQue,
                ChiefComplaint = pcr.ChiefComplaint,
                PastMedicalHistory = pcr.PastMedicalHistory,
                Hpi = pcr.Hpi,
                ActionExamTreatment = pcr.ActionExamTreatment,
                ActiveMotion = pcr.ActiveMotion,
                PassiveMotion = pcr.PassiveMotion,
                Notes = pcr.Notes,
                AnswerDateTime = pcr.AnswerDateTime,
                Answer = pcr.Answer,
                AnswerDiagnose = pcr.AnswerDiagnose,
                AnswerPlan = pcr.AnswerPlan,
                AnswerAction = pcr.AnswerAction,
                ToRegistrationNo = pcr.ToRegistrationNo,
                ToAppointmentNo = pcr.ToAppointmentNo,
                IsPhysiotherapy = pcr.IsPhysiotherapy,
                PatientId = pcr.PatientID,
                SrconsultAnswerType = pcr.SRConsultAnswerType,
                IsVoid = pcr.IsVoid,
                PhysicianSign = pcr.PhysicianSign,
                PhysicianAnswerSign = pcr.PhysicianAnswerSign
            };
        }
    }
}
