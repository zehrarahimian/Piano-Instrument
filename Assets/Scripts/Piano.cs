using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    private void Start(){
        audioSource = GetComponent<AudioSource> ();
    }

    public void PlaySound(string name) {
        switch(name)
        {
            case "E":
            audioSource.PlayOneShot (audioClip[0]);
            break;
            case "D":
            audioSource.PlayOneShot (audioClip[1]);
            break;
            case "C":
            audioSource.PlayOneShot (audioClip[2]);
            break;
            case "B":
            audioSource.PlayOneShot (audioClip[3]);
            break;
            case "A":
            audioSource.PlayOneShot (audioClip[4]);
            break;
            case "G":
            audioSource.PlayOneShot (audioClip[5]);
            break;
            case "F":
            audioSource.PlayOneShot (audioClip[6]);
            break;
            case "D#":
            audioSource.PlayOneShot (audioClip[7]);
            break;
            case "C#":
            audioSource.PlayOneShot (audioClip[8]);
            break;
            case "A#":
            audioSource.PlayOneShot (audioClip[9]);
            break;
            case "G#":
            audioSource.PlayOneShot (audioClip[10]);
            break;
            case "F#":
            audioSource.PlayOneShot (audioClip[11]);
            break;
            
        }
    }
}
