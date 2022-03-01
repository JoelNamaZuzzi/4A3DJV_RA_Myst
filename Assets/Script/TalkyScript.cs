using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkyScript : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip story;
    public GameObject NextCanvas;
    void Awake()
    {
        Audio = GetComponent<AudioSource>();
    }
    
    public void PlayStory(){
        Audio.PlayOneShot(story);
        NextCanvas.SetActive(true);
    }
}
