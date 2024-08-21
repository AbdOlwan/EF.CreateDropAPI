namespace EF.CreateDropAPI.Entities
{
    public class Individual : Participant
    {
        public string Univirstiy { get; set; }
        public int YearOfGraduate { get; set; }
        public bool IsIntern { get; set; }
    }
}
