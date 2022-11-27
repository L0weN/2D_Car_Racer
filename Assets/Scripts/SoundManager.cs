using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource takeOff, acceleration;

    private void Start()
    {
        Invoke("SpeedUp", 2f);
    }

    public void SpeedUp()
    {
        acceleration.playOnAwake = false;
        acceleration.loop = false;
        takeOff.playOnAwake = true;
        takeOff.loop = true;
    }
}
