using System;
public class Word
{
    //Create a list to store the hidden words
    private List<string>_hiddenWords = new List<string>();
    // Split the scripture text into words
    private string[] words = Scripture.GetText().Split(" ");
    // Hide a few random 
    public void hideWord()
    {
        
        Random random = new Random();
        int numWordsToHide = random.Next(3);
        for (int i = 0; i < numWordsToHide; i++)
        {
            int index = random.Next(words.Length);
            if (!_hiddenWords.Contains(words[index]))
            {
                _hiddenWords.Add(words[index]);
                words[index] = new string('_', words[index].Length);
            }
        }
    }
    public List<string> GetHidden()
    {
        return _hiddenWords;
    }
    public string[] GetWords()
    {
        return words;
    }

    public void Display()
    {
        // Display the scripture with hidden words
        Console.WriteLine ($"{Scripture.GetReference()}  {string.Join(" ", words)}");
    }
    
}

