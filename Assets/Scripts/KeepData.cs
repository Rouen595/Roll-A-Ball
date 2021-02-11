using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{

    public static string PlayerName = "default name";
    public static bool OversizeBall;
    public static int RoundsToPlay = 3;
    public static float PlayerSpeedMultiplier = 1.0f;


    public InputField playerName;
    public Toggle ballSize;
    public Dropdown roundsToPlay;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
