using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeed : MonoBehaviour
{
    public static float gameSpeed;

    public void Change(float f)
    {
        GetComponent<Text>().text = f.ToString();
        gameSpeed = f;
    }
}
