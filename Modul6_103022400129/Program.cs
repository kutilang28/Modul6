namespace Modul6_103022400129
{
    class SayaMusicTrack
    {
        private int id;
        string title;
        private int playCount;

        public SayaMusicTrack(String title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {this.id}, title: {this.title}, playCount: {this.playCount} ");
        }
        public int GetPlaycount()
        {
            return this.playCount;
        }
    }

    class SayaMusicUser
    {
        private int id;
        string username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.username = username;
            this.uploadedTracks = new List<SayaMusicTrack>();
        }
        public int GetTotalPlayCount()
        {
            int total = 0;
            foreach (var item in uploadedTracks)
            {
                total += item.GetPlaycount();
            }
            return total;
        }

        public void AddTrack(SayaMusicTrack track)
        {
            uploadedTracks.Add(track);
        }

        public void PrintAllRecord()
        {
            Console.WriteLine($"Username: {this.username}");
            foreach (var item in uploadedTracks)
            {
                item.PrintTrackDetails();
            }

            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        { 
            SayaMusicTrack track1 = new SayaMusicTrack("Fuel");
            track1.IncreasePlayCount(12000);
            SayaMusicTrack track2 = new SayaMusicTrack("NightTrain");
            track2.IncreasePlayCount(12000);
            SayaMusicTrack track3 = new SayaMusicTrack("Seek and Destroy");
            track3.IncreasePlayCount(12000);
            SayaMusicTrack track4 = new SayaMusicTrack("One - metallica");
            track4.IncreasePlayCount(12000);
            SayaMusicTrack track5 = new SayaMusicTrack("Sweet Child O' mine");
            track5.IncreasePlayCount(12000);
            SayaMusicTrack track6 = new SayaMusicTrack("Patience");
            track6.IncreasePlayCount(12000);
            SayaMusicTrack track7 = new SayaMusicTrack("Enter Sandman");
            track7.IncreasePlayCount(12000);
            SayaMusicTrack track8 = new SayaMusicTrack("Whiplash");
            track8.IncreasePlayCount(12000);
            SayaMusicTrack track9 = new SayaMusicTrack("Hysteria");
            track9.IncreasePlayCount(12000);
            SayaMusicTrack track10 = new SayaMusicTrack("Supermassive Black Hole");
            track10.IncreasePlayCount(12000);

            SayaMusicUser user = new SayaMusicUser("Dewow metal");
            user.AddTrack(track1);
            user.AddTrack(track2);
            user.AddTrack(track3);
            user.AddTrack(track4);
            user.AddTrack(track5);
            user.AddTrack(track6);
            user.AddTrack(track7);
            user.AddTrack(track8);
            user.AddTrack(track9);
            user.AddTrack(track10);

            user.PrintAllRecord();
        }
    }
}