using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickColor : MonoBehaviour
{
    public static int playerColor;
    //public Text ShowColor;
    public Dropdown SelectColor;

    public void ChangeColor()
    {
        switch(SelectColor.value)
        {
            case 1:
                playerColor = 1;
                //ShowColor.text = "Red";
                break;
            case 2:
                playerColor = 2;
                //ShowColor.text = "Green";
                break;
            case 3:
                playerColor = 3;
                //ShowColor.text = "Blue";
                break;
            default:
                playerColor = 1;
                //ShowColor.text = "Please select a color";
                break;

        }
    }
}
