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
    
    public void OnChangeKnobValue(float k)
    {
        Debug.Log(k);
        if (k>0.8f && k<=0.9f)
        {
            Audio.Stop();
            Audio.clip = SomeTalk;
            Audio.Play();
        }
    }


}
