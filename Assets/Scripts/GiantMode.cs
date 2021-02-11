using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiantMode : MonoBehaviour
{
    public static bool giant;

    public Toggle myToggle;

    public void Giant(bool newValue)
    {

        if (newValue)
        {
            giant = true;
        }

        else
        {
            giant = false;
        }

    }
}
