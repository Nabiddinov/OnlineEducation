namespace OnlineEducation.Interfaces
{
    internal interface ICourseDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }

        public void GetDetails();
    }
}
