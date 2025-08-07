public class Anagram(string baseWord)
{
    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagrams = [];
        
        foreach (var t in potentialMatches)
        {
            if (t.ToLower().Equals(baseWord.ToLower()))
                continue;
            var isMatch = new string(t.ToLower().Order().ToArray())
                .Equals(new string(baseWord.ToLower().Order().ToArray()));
            if (isMatch)
                anagrams.Add(t);
        }

        return anagrams.ToArray();
    }
}