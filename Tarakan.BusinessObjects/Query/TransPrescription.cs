using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Custom;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class TransPrescription : BaseQuery, ITransPrescription
    {
        private readonly IAppUser _appUser;
        public TransPrescription(AppDbContext context, IAppUser appUser) : base(context)
        {
            _appUser = appUser;
        }

        public List<TransPrescriptionDto> GetCurrentPrescription(List<string> regNos)
        {
            if (regNos.Count == 0)
                return [];

            var tpQ = new EntitySpaces.Generated.TransPrescriptionQuery("tpQ");

            tpQ.Select(tpQ.RegistrationNo, tpQ.PrescriptionNo, tpQ.PrescriptionDate, tpQ.CreatedByUserID, tpQ.IsVoid);
                
            if (regNos.Count == 1)
                tpQ.Where(tpQ.RegistrationNo == regNos[0]);
            else
                tpQ.Where(tpQ.RegistrationNo.In(regNos));

            var dt = tpQ.LoadDataTable();
            if (dt.Rows.Count == 0)
                return [];

            var list = new List<TransPrescriptionDto>();
            foreach (DataRow dr in dt.Rows)
            {
                #region Prescription Item
                var prescItem = GetPrescriptionItem((string)dr["PrescriptionNo"]);
                var sbItem = new StringBuilder();
                if (prescItem.Count > 0)
                {
                    int number = 1;
                    sbItem.AppendLine("<ul class=\"list-group\">");
                    foreach (var item in prescItem)
                    {
                        sbItem.AppendLine($"<li class=\"list-group-item\">{number}. {item.ItemName} {item.tpi.TakenQty} {item.DosageUnit} ({item.ConsumeMethod}) <br/> {Converter.Currency(item.tpi.LineAmount, "id-ID")}</li>");
                        number++;
                    }
                    sbItem.AppendLine("</ul>");
                }
                #endregion

                var au = _appUser.AppUserLoad((string)dr["CreatedByUserID"]);
                var sb = new StringBuilder();
                sb.AppendLine($"<div class=\"card\" style=\"{((bool)dr["IsVoid"] ? "text-decoration: line-through" : "")}\">");
                sb.AppendLine($"<h5 class=\"card-header text-center\" style=\"background-color: {Integrated.GetColorOfUserType(au.au.SruserType)}\">{dr["PrescriptionNo"]} @ {Converter.DateFormat((DateTime)dr["PrescriptionDate"], Const.Dateshortmonth)} By {au.au.UserName}</h5>");
                sb.AppendLine("<div class=\"card-body\">");
                sb.AppendLine(sbItem.ToString());
                sb.AppendLine("</div>");
                sb.AppendLine("</div>");
                var data = new TransPrescriptionDto
                {
                    tp = new EntityFramework.Models.TransPrescription
                    {
                        RegistrationNo = (string)dr["RegistrationNo"],
                        PrescriptionNo = (string)dr["PrescriptionNo"]
                    },
                    Result = sb.ToString()
                };
                list.Add(data);
            }
            return list;
        }

        public List<TransPrescriptionDto> GetHistoryPrescription(List<string> regNos)
        {
            if (regNos.Count == 0)
                return [];

            var tpQ = new EntitySpaces.Generated.TransPrescriptionQuery("tpQ");

            tpQ.Select(tpQ.RegistrationNo, tpQ.PrescriptionNo, tpQ.PrescriptionDate, tpQ.CreatedByUserID, tpQ.IsVoid);

            if (regNos.Count == 1)
                tpQ.Where(tpQ.RegistrationNo == regNos[0]);
            else
                tpQ.Where(tpQ.RegistrationNo.In(regNos));

            var dt = tpQ.LoadDataTable();
            if (dt.Rows.Count == 0)
                return [];

            var list = new List<TransPrescriptionDto>();
            foreach (DataRow dr in dt.Rows)
            {
                #region Prescription Item
                var prescItem = GetPrescriptionItem((string)dr["PrescriptionNo"]);
                var sbItem = new StringBuilder();
                if (prescItem.Count > 0)
                {
                    int number = 1;
                    sbItem.AppendLine("<ul class=\"list-group\">");
                    foreach (var item in prescItem)
                    {
                        sbItem.AppendLine($"<li class=\"list-group-item\">{number}. {item.ItemName} {item.tpi.TakenQty} {item.DosageUnit} ({item.ConsumeMethod}) <br/> {Converter.Currency(item.tpi.LineAmount, "id-ID")}</li>");
                        number++;
                    }
                    sbItem.AppendLine("</ul>");
                }
                #endregion

                var au = _appUser.AppUserLoad((string)dr["CreatedByUserID"]);
                var sb = new StringBuilder();
                sb.AppendLine($"<div class=\"card\" style=\"{((bool)dr["IsVoid"] ? "text-decoration: line-through" : "")}\">");
                sb.AppendLine($"<h5 class=\"card-header text-center\" style=\"background-color: {Integrated.GetColorOfUserType(au.au.SruserType)}\">{dr["PrescriptionNo"]} @ {Converter.DateFormat((DateTime)dr["PrescriptionDate"], Const.Dateshortmonth)} By {au.au.UserName}</h5>");
                sb.AppendLine("<div class=\"card-body\">");
                sb.AppendLine(sbItem.ToString());
                sb.AppendLine("</div>");
                sb.AppendLine("</div>");
                var data = new TransPrescriptionDto
                {
                    tp = new EntityFramework.Models.TransPrescription
                    {
                        RegistrationNo = (string)dr["RegistrationNo"],
                        PrescriptionNo = (string)dr["PrescriptionNo"]
                    },
                    Result = sb.ToString()
                };
                list.Add(data);
            }
            return list;
        }

        public List<TransPrescriptionItemDto> GetPrescriptionItem(string prescNo)
        {
            if (string.IsNullOrEmpty(prescNo))
                return [];

            var query = from tpi in _context.TransPrescriptionItems
                        join i in _context.Items
                            on tpi.ItemId equals i.ItemId
                        join iu in _context.AppStandardReferenceItems
                            on new { StandardReferenceId = "ItemUnit", ItemId = tpi.SritemUnit }
                            equals new { iu.StandardReferenceId, iu.ItemId }
                        join du in _context.AppStandardReferenceItems
                            on new { StandardReferenceId = "DosageUnit", ItemId = tpi.SrdosageUnit }
                            equals new { du.StandardReferenceId, du.ItemId }
                        join cm in _context.ConsumeMethods
                            on tpi.SrconsumeMethod equals cm.SrconsumeMethod
                        where tpi.PrescriptionNo == prescNo
                        select new { tpi, i.ItemName, ItemUnit = iu.ItemName, DosageUnit = du.ItemName, ConsumeMethod = cm.SrconsumeMethodName };

            if (!query.Any())
                return [];

            var list = new List<TransPrescriptionItemDto>();
            foreach (var item in query)
            {
                var tpi = new TransPrescriptionItemDto
                {
                    tpi = item.tpi,
                    ItemName = item.ItemName,
                    ItemUnit = item.ItemUnit,
                    DosageUnit = item.DosageUnit,
                    ConsumeMethod = item.ConsumeMethod
                };
                list.Add(tpi);
            }
            return list;
        }
    }
}
