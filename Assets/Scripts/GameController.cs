using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public string Word = "EUGH";
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI OurInput;
    public TMP_InputField InputFeild;

    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
    }

    public void OnInputChanged(string input)
    {
        OurInput.text = input;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}