namespace InspectionAPI
{
    public class Inpection
    {
        public int Id { get; set; }

        public string Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}
