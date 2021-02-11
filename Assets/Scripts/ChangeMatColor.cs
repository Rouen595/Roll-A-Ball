using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatColor : MonoBehaviour
{
    public Material myMaterial;

    void ChangePlayerColor()
    {
        switch (PickColor.playerColor)
        {
            case 1:
                myMaterial.color = Color.red;
                break;
            case 2:
                myMaterial.color = Color.green;
                break;
            case 3:
                myMaterial.color = Color.blue;
                break;
            default:
                myMaterial.color = Color.red;
                break;

        }
    }
}
