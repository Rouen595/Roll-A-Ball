using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public static string difficultyLevel; // can use an int as well, 1 = easy, 2 = normal, 3 = hard
    public Text ShowLevel;   // variables are camel casing, objects are capital for each word
    public Dropdown PickLevel;



    public void ChangeLevel()
    {
        switch(PickLevel.value)
        {
            case 1:
                ShowLevel.text = "Easy";
                break;
            case 2:
                ShowLevel.text = "Normal";
                break;
            case 3:
                ShowLevel.text = "Hard";
                break;
            default:
                ShowLevel.text = "Please select a difficulty";
                break;

        }
    }


}
