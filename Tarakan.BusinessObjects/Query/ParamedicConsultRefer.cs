using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class ParamedicConsultRefer : BaseQuery, IParamedicConsultRefer
    {
        public ParamedicConsultRefer(AppDbContext context) : base(context)
        {

        }

        public ParamedicConsultReferDto LoadByPrimaryKey(string refNo)
        {
            if (string.IsNullOrEmpty(refNo))
                return new ParamedicConsultReferDto();

            var pcr = _context.ParamedicConsultRefers
                .Where(p => p.ConsultReferNo == refNo).FirstOrDefault();

            if (pcr == null || string.IsNullOrEmpty(pcr.ConsultReferNo))
                return new ParamedicConsultReferDto();

            return new ParamedicConsultReferDto
            {
                ConsultReferNo = pcr.ConsultReferNo,
                ConsultDateTime = pcr.ConsultDateTime,
                RegistrationNo = pcr.RegistrationNo,
                ParamedicId = pcr.ParamedicId,
                SrparamedicConsultType = pcr.SrparamedicConsultType ?? string.Empty,
                ConsultReferType = pcr.ConsultReferType,
                ToServiceUnitId = pcr.ToServiceUnitId ?? string.Empty,
                ToParamedicId = pcr.ToParamedicId ?? string.Empty,
                ToRoomId = pcr.ToRoomId ?? string.Empty,
                ToRegistrationQue = pcr.ToRegistrationQue,
                ChiefComplaint = pcr.ChiefComplaint ?? string.Empty,
                PastMedicalHistory = pcr.PastMedicalHistory ?? string.Empty,
                Hpi = pcr.Hpi ?? string.Empty,
                ActionExamTreatment = pcr.ActionExamTreatment ?? string.Empty,
                ActiveMotion = pcr.ActiveMotion ?? string.Empty,
                PassiveMotion = pcr.PassiveMotion ?? string.Empty,
                Notes = pcr.Notes ?? string.Empty,
                AnswerDateTime = pcr.AnswerDateTime,
                Answer = pcr.Answer ?? string.Empty,
                AnswerDiagnose = pcr.AnswerDiagnose ?? string.Empty,
                AnswerPlan = pcr.AnswerPlan ?? string.Empty,
                AnswerAction = pcr.AnswerAction ?? string.Empty,
                ToRegistrationNo = pcr.ToRegistrationNo ?? string.Empty,
                ToAppointmentNo = pcr.ToAppointmentNo ?? string.Empty,
                IsPhysiotherapy = pcr.IsPhysiotherapy,
                PatientId = pcr.PatientId ?? string.Empty,
                SrconsultAnswerType = pcr.SrconsultAnswerType ?? string.Empty,
                IsVoid = pcr.IsVoid,
                PhysicianSign = pcr.PhysicianSign ?? [],
                PhysicianAnswerSign = pcr.PhysicianAnswerSign ?? []
            };
        }
    }
}
