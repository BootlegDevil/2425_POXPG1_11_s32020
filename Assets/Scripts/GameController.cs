using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public string Word = "banan";
    public int LivesCount = 10;
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI OurInput;
    public TextMeshProUGUI SuggestionText;
    public TMP_InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
        OurInput.text = $"Tries Left: {LivesCount}.";
    }

    public void OnInputChanged(string input)
    {
        OurInput.text = input;
    }
 public void OnClick()
    {
        Debug.Log($"Button clicked.");
        LivesCount -= 1;
        OurInput.text = $"Tries Left: {LivesCount}.";
        
        if(Word == InputField.text)
        {
            Debug.Log($"Correct guess");
            return;
        }
        if(Word.Length != InputField.text.Length)
        {
            SuggestionText.text = $"Length is not correct.";
            return;
        }

        int bullsCount = CountBulls();
        int cowsCount = CountCows();

        SuggestionText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";
    }


    public int CountBulls()
    {
        int result = 0;

        for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == InputField.text[i])
                    {
                        result++;
                    }
                }
        return result;
    }

    public int CountCows()
    {
        int result = 0;

        for (int i = 0; i < Word.Length; i++)
        {
            if (Word[i] != InputField.text[i] && Word.Contains(InputField.text[i]))
            {
                result++;
            }
        }

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}