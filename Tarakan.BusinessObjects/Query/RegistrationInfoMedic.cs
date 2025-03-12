using EntitySpaces.DynamicQuery;
using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationInfoMedic : IRegistrationInfoMedic
    {
        private readonly IRegistration _registration;
        private readonly IAppParameter _appParameter;
        private readonly AppDbContext _context;

        public RegistrationInfoMedic(IRegistration registration, IAppParameter appParameter, AppDbContext context)
        {
            _registration = registration;
            _appParameter = appParameter;
            _context = context;
        }

        [Obsolete]
        public List<RegistrationInfoMedicDto> IntegratedNotes(string regType, string regNo, List<string> regNoList, string patId, string filter)
        {
            #region Variabel
            var dtb = new DataTable();
            var lastRegNos = _registration.RegistrationNos(patId, _appParameter.ParameterInteger("EmrHistoryRegistrationCount"), regNo);
            #endregion

            #region Patient Assessment
            var rimQ = new EntitySpaces.Generated.RegistrationInfoMedicQuery("rimQ");
            var paQ = new EntitySpaces.Generated.PatientAssessmentQuery("paQ");
            var asriQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("asriQ");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");

            rimQ.Select(rimQ.RegistrationInfoMedicID, rimQ.RegistrationNo, rimQ.ParamedicID, rimQ.SRMedicalNotesInputType, rimQ.DateTimeInfo, rimQ.Info1, rimQ.Info2, rimQ.Info3, rimQ.Info4, rimQ.Info5, rimQ.IsApproved.Coalesce("CONVERT(bit,0)").As("IsApproved"), rimQ.ApprovedDatetime, rimQ.ApprovedByUserID,
                rimQ.CreatedDateTime, rimQ.CreatedByUserID, rimQ.IsDeleted.Coalesce("CONVERT(bit,0)").As("IsDeleted"), rimQ.ServiceUnitID, rimQ.AttendingNotes, paQ.SRAssessmentType, paQ.IsInitialAssessment, "<CAST(0 as bit) as IsFromAskep>", asriQ.ItemName.Coalesce("''").As("AssessmentTypeName"),
                rimQ.SRUserType, rimQ.PpaInstruction, "<'' as ReferenceToPhrNo>", rimQ.IsCreatedByUserDpjp, rimQ.PrescriptionCurrentDay, rimQ.DpjpNotes, rimQ.ReferenceNo, rQ.FromRegistrationNo,
                "<'' as SubmitBy>", "<'' as ReceiveBy>", "<'' as TemplateID>", "<'' as SRNursingDiagnosaLevel>", "<'' as SRNursingCarePlanning>")
                .LeftJoin(paQ).On(rimQ.RegistrationInfoMedicID == paQ.RegistrationInfoMedicID)
                .LeftJoin(asriQ).On(paQ.SRAssessmentType == asriQ.ItemID && asriQ.StandardReferenceID == "AssessmentType")
                .InnerJoin(rQ).On(rimQ.RegistrationNo == rQ.RegistrationNo)
                .OrderBy(rimQ.RegistrationInfoMedicID.Descending);

            if (regType == Const.Inpatient)
            {
                if (regNoList.Count > 1)
                    rimQ.Where(rimQ.RegistrationNo.In(regNoList));
                else
                    rimQ.Where(rimQ.RegistrationNo == regNoList[0]);
            }
            else
            {
                if (lastRegNos.Count == 0)
                    rimQ.Where(rimQ.RegistrationNo == lastRegNos[0]);
                else
                    rimQ.Where(rimQ.RegistrationNo.In(lastRegNos));
            }

            if (!string.IsNullOrEmpty(filter))
                rimQ.Where(rimQ.SRUserType == filter);

            dtb = rimQ.LoadDataTable();
            #endregion

            #region Nursing Notes
            var ndtQ = new EntitySpaces.Generated.NursingDiagnosaTransDTQuery("ndtQ");
            var nthQ = new EntitySpaces.Generated.NursingTransHDQuery("nthQ");
            rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");

            ndtQ.Select(ndtQ.Id.Cast(esCastType.String).As("RegistrationInfoMedicID"), nthQ.RegistrationNo, ndtQ.ParamedicID, ndtQ.ExecuteDateTime.As("DateTimeInfo"), ndtQ.A.As("Info3"), ndtQ.P.As("Info4"), ndtQ.Info5,
                ndtQ.IsApproved.Coalesce("CONVERT(bit,0)").As("IsApproved"), ndtQ.ApprovedDatetime, ndtQ.ApprovedByUserID, ndtQ.CreateDateTime.As("CreatedDateTime"), ndtQ.CreateByUserID.As("CreatedByUserID"), ndtQ.IsDeleted.Coalesce("CONVERT(bit,0)").As("IsDeleted"),
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' THEN 'SBAR' WHEN ndtQ.NursingDiagnosaName='ADIME' THEN 'ADIME' WHEN ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN 'SOAP' WHEN ndtQ.NursingDiagnosaName = 'Handover Patient' THEN ndtQ.NursingDiagnosaName  ELSE 'Notes' END as SRMedicalNotesInputType>",
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' OR ndtQ.NursingDiagnosaName = 'ADIME' OR ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.NursingDiagnosaName = 'Handover Patient' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN S ELSE ndtQ.NursingDiagnosaName END as Info1>",
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' OR ndtQ.NursingDiagnosaName = 'ADIME' OR ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.NursingDiagnosaName = 'Handover Patient' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN O ELSE ndtQ.Respond END as Info2>",
                "<'' as ServiceUnitID>", "<'' as AttendingNotes>", "<'NurseNotes' as SRAssessmentType>", "<CAST(0 as bit) as IsInitialAssessment>", "<CAST(1 as bit) as IsFromAskep>", "<'' as AssessmentTypeName>", "<CAST(0 as bit) as IsCreatedByUserDpjp>",
                "<CAST(ISNULL(ndtQ.TemplateID,0) as varchar(10)) as TemplateID>", "<'' as ReferenceNo>",
                ndtQ.SRUserType, ndtQ.PpaInstruction, ndtQ.ReferenceToPhrNo, ndtQ.PrescriptionCurrentDay, ndtQ.SubmitBy, ndtQ.ReceiveBy, ndtQ.DpjpNotes, ndtQ.SRNursingDiagnosaLevel, ndtQ.SRNursingCarePlanning, rQ.FromRegistrationNo)
                .InnerJoin(nthQ).On(nthQ.TransactionNo == ndtQ.TransactionNo)
                .InnerJoin(rQ).On(rQ.RegistrationNo == nthQ.RegistrationNo);

            if (regType == Const.Inpatient)
            {
                if (regNoList.Count > 1)
                    ndtQ.Where(nthQ.RegistrationNo.In(regNoList));
                else
                    ndtQ.Where(nthQ.RegistrationNo == regNoList[0]);
            }
            else
            {
                if (lastRegNos.Count == 1)
                    ndtQ.Where(nthQ.RegistrationNo == lastRegNos[0]);
                else
                    ndtQ.Where(nthQ.RegistrationNo.In(lastRegNos));
            }

            if (!string.IsNullOrEmpty(filter))
                ndtQ.Where(ndtQ.SRUserType == filter);

            ndtQ.Where(ndtQ.Or(ndtQ.SRNursingDiagnosaLevel == "31", ndtQ.SRNursingDiagnosaLevel == "40"));
            var dtAskep = ndtQ.LoadDataTable();
            foreach (var r in dtAskep.AsEnumerable()
                .Where(dr => dr.Field<string>("SRNursingDiagnosaLevel") == "40" & dr.Field<string>("SRNursingCarePlanning") != "01"))
            {
                var nicEval = EntitySpaces.Generated.NursingDiagnosaTransDT.DetailEvaluationByEvaluationIdHtml(Convert.ToInt32(r["RegistrationInfoMedicID"]));
                if (r["SRMedicalNotesInputType"].ToString() == "ADIME")
                    r["Info3"] = r["Info3"].ToString() + nicEval;
                else
                    r["Info4"] = r["Info4"].ToString() + nicEval;
            }
            #endregion

            #region Process
            if (dtAskep.Rows.Count > 0)
            {
                foreach (DataRow dr in dtAskep.Rows)
                {

                }
            }
            #endregion

            dtb.Merge(dtAskep);
            return Converter.DataTableToList<RegistrationInfoMedicDto>(dtb);
        }
    }
}
