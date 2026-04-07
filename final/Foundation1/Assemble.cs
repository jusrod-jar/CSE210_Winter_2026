class Assemble
{
        private List<Video> _videos = new List<Video>();
        private Random random = new Random();
        private GetRandom getRandom = new GetRandom();
    public void ShowcaseVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }

    public void AssembleVideos()
    {
        int videoCount = random.Next(3, 5);
        for (int i = 0; i < videoCount; i++)
        {
            (string author, string title, int length) = getRandom.GetRandomVideo();
            Video video = new Video(author, title, length);
            _videos.Add(video);
        }
    }
}