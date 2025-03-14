﻿using Tarakan.BusinessObjects.Dto;

namespace TarakanSIMRS.Areas.Tarakan.Models.HealthRecord
{
    public class HealthRecordViewModel
    {
        public List<RegistrationDto>? getRegistration { get; set; }

        #region Showing Condition
        public bool IsLoadBillingProgress { get; set; }
        #endregion
    }
}
