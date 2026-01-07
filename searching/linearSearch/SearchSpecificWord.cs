/*Search for a Specific Word in a List of Sentences
Problem: You are given an array of sentences. Write a program that performs Linear Search
to find the first sentence containing a specific word.
*/
using System;

public class SentenceSearch
{
    private readonly string[] sentences;

    public SentenceSearch(string[] sentences)
    {
        this.sentences = sentences;
    }

    public string FindSentenceContainingWord(string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return sentences[i]; 
            }
        }

        return null; 
    }
}
