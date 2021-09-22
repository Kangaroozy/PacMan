using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    AudioSource BACKGROUND_INTRO;
    // Start is called before the first frame update
    void Start()
    {
        BACKGROUND_INTRO.PlayScheduled(AudioSettings.dspTime + 0.5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
