﻿using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class ServiceUnit : BaseQuery, IServiceUnit
    {
        public ServiceUnit(AppDbContext context) : base(context)
        {
            
        }

        public string GetServiceUnitName(string suId)
        {
            if (string.IsNullOrEmpty(suId))
                return string.Empty;

            var query = (from su in _context.ServiceUnits
                         where su.ServiceUnitId == suId
                         select new { su.ServiceUnitId, su.ServiceUnitName }).FirstOrDefault();

            return query == null || string.IsNullOrEmpty(query.ServiceUnitId) ? string.Empty : query.ServiceUnitName;
        }

        [Obsolete]
        public List<ServiceUnitDto> GetServiceUnit(string userId, string srRegistrationType, bool? isActive)
        {
            var au = new EntitySpaces.Generated.AppUser();
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var ausuQ = new EntitySpaces.Generated.AppUserServiceUnitQuery("ausuQ");

            if (!string.IsNullOrEmpty(userId))
                au.LoadByPrimaryKey(userId);

            if (!string.IsNullOrEmpty(srRegistrationType))
                suQ.Where(suQ.SRRegistrationType == srRegistrationType);
            else
            {
                srQ.Select(srQ.ServiceUnitID)
                    .Where(srQ.IsOperatingRoom == true, srQ.IsShowOnBookingOT == true, srQ.ServiceUnitID == suQ.ServiceUnitID);
                suQ.Where(suQ.Or(suQ.SRRegistrationType.In([Const.Inpatient, Const.Emergency, Const.Outpatient, Const.Medicalcheckup]), suQ.ServiceUnitID.In(srQ)));
            }

            if (isActive.HasValue)
                suQ.Where(suQ.IsActive == isActive.Value);

            if (au.SRUserType == Const.Nurse || (au.SRUserType == Const.Physiotherapy && string.IsNullOrEmpty(au.ParamedicID)))
                suQ.InnerJoin(ausuQ).On(ausuQ.ServiceUnitID == suQ.ServiceUnitID && ausuQ.UserID == au.UserID);

            suQ.OrderBy(suQ.ServiceUnitName.Ascending);
            var result = new List<ServiceUnitDto>();
            if (suQ.LoadDataTable().Rows.Count > 0)
            {
                foreach (DataRow row in suQ.LoadDataTable().Rows)
                {
                    var su = new ServiceUnitDto
                    {
                        ServiceUnitID = row["ServiceUnitID"] != DBNull.Value ? (string)row["ServiceUnitID"] : string.Empty,
                        ServiceUnitName = row["ServiceUnitName"] != DBNull.Value ? (string)row["ServiceUnitName"] : string.Empty,
                        DepartmentID = row["DepartmentID"] != DBNull.Value ? (string)row["DepartmentID"] : string.Empty,
                        ShortName = row["ShortName"] != DBNull.Value ? (string)row["ShortName"] : string.Empty,
                        SRRegistrationType = row["SRRegistrationType"] != DBNull.Value ? (string)row["SRRegistrationType"] : string.Empty,
                        IsActive = row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"])
                    };
                    result.Add(su);
                }
            }

            return result;
        }
    }
}
