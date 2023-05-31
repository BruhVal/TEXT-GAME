using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame_Manager : MonoBehaviour

{

    public int hpValue, sanityValue;

    public TextMeshProUGUI hpTextValue, sanityTextValue, storyTextValue;

    public string startOfStory;
    


    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        startOfStory = "You Have Awoken";
        
    }

    // Update is called once per frame
    void Update()
    {
        hpTextValue.text = hpValue.ToString();
        sanityTextValue.text = sanityValue.ToString();
        storyTextValue.text = startOfStory;
    }

    public void EnterRoom()
    {
        hpValue -= 10;
        startOfStory = "It was a trap! You Died X-X";
        level1_CHoices.SetActive(false);
    }
    public void LeaveRoom()
    {
        hpValue = 10;
        startOfStory = "You left... ";
    }
    public void DoFlip()
    {
        hpValue -= 10;
        startOfStory = "You Broke your neck You Died X_X";
    }
}
