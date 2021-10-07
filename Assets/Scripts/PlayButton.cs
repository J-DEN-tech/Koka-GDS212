using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public static bool playing = false;

    public void OnClick()
    {
        playing = !playing;
    }
}
