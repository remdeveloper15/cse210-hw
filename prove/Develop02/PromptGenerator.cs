using System.Dynamic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"We have been called to serve others! Did you have the chance to serve someone today? ", "Clouds sometimes turn in black. How do you feel today? ", "People that we love always live in our hearts, even if we can't see them. Tell me about someone especial for you... ", "We are always angry! Did you have today an experiencies that you turned furious? ", "I love music! What is the song that you have been listening this week?", "Pets are always an important of us! Do you have it? Tell me about it! ", "Hey, It's okey. Even it's today is not great, there is always one good thing that happened to you. Think about it...", "WOW! Today was perfect! But remember, there is always something that we can do to be a better person! What's in your mind? ", "I LOVE YOU! Give you the oportunity to tell someone special for you how much do you love him/her. Tell me what's happened! " };
    

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        string finalPrompt = _prompts[index];
         return "---" + finalPrompt + "---"; 
    }
}