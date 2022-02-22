using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkyScript : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip story;
    void Awake()
    {
        Audio = GetComponent<AudioSource>();
    }
    
    public void PlayStory(){
        Audio.PlayOneShot(story);
    }
}
