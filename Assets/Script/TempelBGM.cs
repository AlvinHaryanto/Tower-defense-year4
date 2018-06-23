using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempelBGM : MonoBehaviour {

    public AudioClip clip;
    private void Start()
    {
        BGM.instance.source.volume = 0.5f;
        BGM.instance.PlayBGM(clip);
    }
    

}
