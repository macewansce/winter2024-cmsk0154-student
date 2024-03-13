namespace Module4.Lesson19.Queues
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
