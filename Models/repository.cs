namespace proje1.Models
{
    public static class Repository1
    {
        private static List<Candidate> apps = new List<Candidate>();
        public static IEnumerable<Candidate> Apps => apps;

        public static void AddApplication(Candidate candidate)
        {
            apps.Add(candidate);
        }
        
    }


}