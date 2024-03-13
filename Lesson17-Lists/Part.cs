namespace Module4.Lesson17.Lists
{
    public class Part
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return $"Id: {PartId}  Name: {PartName}";
        }
    }
}
