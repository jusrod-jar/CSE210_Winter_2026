class GetRandom
{
    private List<string> _videoAuthors = new List<string> 
    {
        "CorygamesYT", "JamesdoesStuffYT", "GaryDoesArtYT", "HannahBananaYT", "LebronJahamesYT", "JessiebeDrawingYT", "AuroraflatsYT", "PlatoSpeaksYT"
    };
    private List<string> _videoTitles = new List<string>
    {
        "Elden Ring Letsplay #9 (Maliketh)", "Iranian war update: Almost over?", "Trying new RE9: requiem!", "How to shade your art properly", "Infinite robux glitch *REAL* (2026)", "Trying out hacks on COD, will they cure my bad aim?", "Can a dictionary survive a 9mm?", "Inside look on paris protests (I got pepper sprayed)"
    };
    private List<int> _videoLengths = new List<int>
    {
        900, 689, 1233, 883, 790, 1039, 557, 1090
    };
    private List<string> _commentAuthors = new List<string>
    {
        "hater000", "pinoypinoy", "socrates", "jamescharles", "lebronSPAM", "ih8uu90","XxGamerDudexX", "minecrafPigman", "AsteroidBlaster9000","whyulookinghere7", "AlfredCox", "PubertTheIII", "ILoveFeet33", "THEGooner", "DeathNote_NoDiffs","Quandale_dingle_real"
    };
    private List<string> _commentContent = new List<string>
    {
        "Ts is buns twin", "1:14 That piano", "dawg im crine", "I think ur mutted gang", "who are you and why are you so goated", "7:24 me when I stub my toe", "9:09 super impressive NOT", " 3:50 he reminds me of that one dude from the office", "giving chub vibes right now...", "Yall seen clav get frame mogged?", "I appreciate it",  "that boy said some: "
    };

    public string GetRandomComment()
    {
        return "comment";
    }
    public string GetRandomVideo()
    {
        return "video";
    }
}