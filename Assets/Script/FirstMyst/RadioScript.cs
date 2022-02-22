using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip Noise;
    public AudioClip SomeTalk;
    
    void Awake()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = Noise;
    }

    void Start()
    {
        Audio.Play();
    }
    
    public void OnChangeKnobValue(int k)
    {
        if (k>5 && k<=6)
        {
            Audio.Stop();
            Audio.clip = SomeTalk;
            Audio.Play();
        }
    }


}
