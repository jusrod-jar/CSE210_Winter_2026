using System;
using System.Collections.Generic;
public class Prompt
{
    public string _prompt;

    private List<string> _prompts = new List<string>
    {
        "What color best represents today?",
        "Have I read today? If so, what did I read?",
        "What song would best represent today?",
        "What physical exercise did I get today?",
        "What was my favorite part of today?",
        "Were my neurons firing hard today, or were they going slow? Why?",
        "Was my fit hard today?",
        "Did I do some good philosophical inquiry about my life today? If not, do it right now (mandatory). What did you think about?",
        "Did I get all my work done comfortably?"
    };

    private List<string> _motivationals = new List<string>
    {
        "You got this young neph",
        "Manifesting A+ on this assignment",
        "Manifesting 10/10 into your life",
        "Your hamon is shining brightly",
        "Aristotle <3 you!",
        "Kazakhstan sends their best wishes",
        "Big Ounce is rooting on YOU",
        "Bismallah you will recieve divine intelligence",
        "Bismallah you shall grow 5 inches by tomorrow morning"
    };
    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetMotivation()
    {
        Random random = new Random();
        int index = random.Next(_motivationals.Count);
        return _motivationals[index];
    }
}