﻿using Tarakan.EntityFramework.Models;

namespace Tarakan.BusinessObjects.Dto
{
    public class AppStandardReferenceItemDto
    {
        public string StandardReferenceID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int NumericValue { get; set; }

        #region Custom Variabel
        public string IconCSS { get; set; }
        public string ColorCSS { get; set; }
        #endregion
    }
}
