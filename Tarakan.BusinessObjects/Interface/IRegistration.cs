﻿using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Filter;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IRegistration
    {
        List<RegistrationDto> RegistrationEmr(RegistrationFilter filter, string userId);
        string[] GetMergeRegistration(string regNo);
        string RegistrationTransferStatus(bool isAlreadyTransfer, string transferNo);
        string SoapEntryStatus(string regNo, string parId, string regType);
        RegistrationDto LoadByPrimaryKey(string regNo);
        List<string> RegistrationNos(string patId, int lastCount, string startRegNo);
        List<string> MergeRegistration(string regNo);
    }
}
