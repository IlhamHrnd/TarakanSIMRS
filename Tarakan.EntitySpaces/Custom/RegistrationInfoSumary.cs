namespace Tarakan.EntitySpaces.Generated
{
    public partial class RegistrationInfoSumary
    {
        public static string RegistrationNoteCount(string regNo)
        {
            var ris = new RegistrationInfoSumary();
            if (!ris.LoadByPrimaryKey(regNo))
                return string.Empty;

            return $"<a href=\"#\" title=\"Note\" class=\"noti_container\" onclick=\"openWinRegistrationInfo('{regNo}'); return false;\"><span id=\"noti_{regNo}\" class=\"noti_bubble\">{(ris.NoteCount > 0 ? ris.NoteCount.ToString() : string.Empty)}</span></a>";
        }
    }
}
