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

            var query = (from pcr in _context.ParamedicConsultRefers
                         where pcr.ConsultReferNo == refNo
                         select pcr).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.ConsultReferNo))
                return new ParamedicConsultReferDto();

            return new ParamedicConsultReferDto
            {
                ConsultReferNo = query.ConsultReferNo,
                ConsultDateTime = query.ConsultDateTime,
                RegistrationNo = query.RegistrationNo,
                ParamedicId = query.ParamedicId,
                SrparamedicConsultType = query.SrparamedicConsultType ?? string.Empty,
                ConsultReferType = query.ConsultReferType,
                ToServiceUnitId = query.ToServiceUnitId ?? string.Empty,
                ToParamedicId = query.ToParamedicId ?? string.Empty,
                ToRoomId = query.ToRoomId ?? string.Empty,
                ToRegistrationQue = query.ToRegistrationQue,
                ChiefComplaint = query.ChiefComplaint ?? string.Empty,
                PastMedicalHistory = query.PastMedicalHistory ?? string.Empty,
                Hpi = query.Hpi ?? string.Empty,
                ActionExamTreatment = query.ActionExamTreatment ?? string.Empty,
                ActiveMotion = query.ActiveMotion ?? string.Empty,
                PassiveMotion = query.PassiveMotion ?? string.Empty,
                Notes = query.Notes ?? string.Empty,
                AnswerDateTime = query.AnswerDateTime,
                Answer = query.Answer ?? string.Empty,
                AnswerDiagnose = query.AnswerDiagnose ?? string.Empty,
                AnswerPlan = query.AnswerPlan ?? string.Empty,
                AnswerAction = query.AnswerAction ?? string.Empty,
                ToRegistrationNo = query.ToRegistrationNo ?? string.Empty,
                ToAppointmentNo = query.ToAppointmentNo ?? string.Empty,
                IsPhysiotherapy = query.IsPhysiotherapy,
                PatientId = query.PatientId ?? string.Empty,
                SrconsultAnswerType = query.SrconsultAnswerType ?? string.Empty,
                IsVoid = query.IsVoid,
                PhysicianSign = query.PhysicianSign ?? [],
                PhysicianAnswerSign = query.PhysicianAnswerSign ?? []
            };
        }
    }
}
