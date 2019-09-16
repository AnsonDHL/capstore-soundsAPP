using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{

    public AudioSource source
    { get
        { return 
                
                GetComponent<AudioSource>();
        }
    }
    public void PlayPauseSong()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
        else
        {
            source.Pause();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
