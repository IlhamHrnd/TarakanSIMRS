namespace Tarakan.BusinessObjects.Custom
{
    public class BaseCustom
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string ParamedicID { get; set; }
        public string ServiceUnitID { get; set; }
        public string PersonID { get; set; }
        public string Role { get; set; }
    }

    public class BaseIcon
    {
        #region Icon
        private static string checksquare = "fa-solid fa-square-check";
        private static string eye = "fa-solid fa-eye";
        private static string pensquare = "fa-solid fa-pen-to-square";
        private static string infocircle = "fa-solid fa-circle-info";
        private static string bar = "fa-solid fa-bars";
        private static string medicalnote = "fas fa-notes-medical";
        private static string pills = "fas fa-pills";
        private static string history = "fas fa-history";
        private static string laptop = "fa-solid fa-laptop-medical";
        private static string nurse = "fa-solid fa-user-nurse";
        private static string calender = "fa-solid fa-calendar-days";
        private static string bottle = "fa-solid fa-prescription-bottle-medical";
        private static string file = "fa-solid fa-file";
        private static string retweet = "fa-solid fa-retweet";
        private static string exclamation = "fa-solid fa-triangle-exclamation";
        private static string personrisk = "fa-solid fa-person-walking-with-cane";
        private static string doctor = "fa-solid fa-user-doctor";
        private static string checkcircle = "fa-solid fa-circle-check";
        private static string note = "fa-solid fa-note-sticky";
        private static string capsule = "fa-solid fa-capsules";
        private static string print = "fa-solid fa-print";
        private static string trash = "fa-solid fa-trash";
        private static string folder = "fa-solid fa-folder-open";

        public static string Checksquare { get => checksquare; set => checksquare = value; }
        public static string Eye { get => eye; set => eye = value; }
        public static string Pensquare { get => pensquare; set => pensquare = value; }
        public static string Infocircle { get => infocircle; set => infocircle = value; }
        public static string Bar { get => bar; set => bar = value; }
        public static string Medicalnote { get => medicalnote; set => medicalnote = value; }
        public static string Pills { get => pills; set => pills = value; }
        public static string History { get => history; set => history = value; }
        public static string Laptop { get => laptop; set => laptop = value; }
        public static string Nurse { get => nurse; set => nurse = value; }
        public static string Calender { get => calender; set => calender = value; }
        public static string Bottle { get => bottle; set => bottle = value; }
        public static string File { get => file; set => file = value; }
        public static string Retweet { get => retweet; set => retweet = value; }
        public static string Exclamation { get => exclamation; set => exclamation = value; }
        public static string Personrisk { get => personrisk; set => personrisk = value; }
        public static string Doctor { get => doctor; set => doctor = value; }
        public static string Checkcircle { get => checkcircle; set => checkcircle = value; }
        public static string Note { get => note; set => note = value; }
        public static string Capsule { get => capsule; set => capsule = value; }
        public static string Print { get => print; set => print = value; }
        public static string Trash { get => trash; set => trash = value; }
        public static string Folder { get => folder; set => folder = value; }
        #endregion

        #region Color
        private static string primary = "text-primary";
        private static string secondary = "text-secondary";
        private static string success = "text-success";
        private static string danger = "text-danger";
        private static string warning = "text-warning";
        private static string info = "text-info";
        private static string light = "text-light";
        private static string dark = "text-dark";

        public static string Primary { get => primary; set => primary = value; }
        public static string Secondary { get => secondary; set => secondary = value; }
        public static string Success { get => success; set => success = value; }
        public static string Danger { get => danger; set => danger = value; }
        public static string Warning { get => warning; set => warning = value; }
        public static string Info { get => info; set => info = value; }
        public static string Light { get => light; set => light = value; }
        public static string Dark { get => dark; set => dark = value; }
        #endregion
    }
}
