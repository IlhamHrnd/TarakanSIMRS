namespace Tarakan.BusinessObjects.Dto
{
    public class AppProgramDto
    {
        public string ProgramId { get; set; }

        public string ProgramName { get; set; }

        public bool? IsProgram { get; set; }

        public string ProgramType { get; set; }

        public bool? IsProgramAddAble { get; set; }

        public bool? IsProgramEditAble { get; set; }

        public bool? IsProgramDeleteAble { get; set; }

        public bool? IsProgramViewAble { get; set; }

        public bool? IsProgramApprovalAble { get; set; }

        public bool? IsProgramUnApprovalAble { get; set; }

        public bool? IsProgramVoidAble { get; set; }

        public bool? IsProgramUnVoidAble { get; set; }

        public bool? IsProgramPrintAble { get; set; }

        public bool? IsMenuAddVisible { get; set; }

        public bool? IsMenuHomeVisible { get; set; }

        public bool? IsVisible { get; set; }

        public bool? IsProgramExportAble { get; set; }

        public bool? IsProgramCrossUnitAble { get; set; }

        public bool? IsProgramPowerUserAble { get; set; }
    }
}
