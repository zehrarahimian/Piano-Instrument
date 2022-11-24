using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;
    public Transform[] notesT;

    private void Start(){
        Notes.toneName += PlaySound;
        audioSource = GetComponent<AudioSource> ();
    }

    private void OnDestroy(){
        Notes.toneName -= PlaySound;
    }
    private void Update(){
        if(Input.GetMouseButtonUp(0)) {
            for(int i=0; i < notesT.Length; i++) {
            notesT[i].localScale = new Vector3 (1,1,1);
        }
        }
        
    }

    public void PlaySound(string name) {
        switch(name)
        {
            case "E":
            audioSource.PlayOneShot (audioClip[7]);
            notesT[0].localScale = pos();
            break;
            case "D":
            audioSource.PlayOneShot (audioClip[6]);
            notesT[1].localScale = pos();
            break;
            case "C":
            audioSource.PlayOneShot (audioClip[4]);
            notesT[2].localScale = pos();
            break;
            case "B":
            audioSource.PlayOneShot (audioClip[2]);
            notesT[3].localScale = pos();
            break;
            case "A":
            audioSource.PlayOneShot (audioClip[1]);
            notesT[4].localScale = pos();
            break;
            case "G":
            audioSource.PlayOneShot (audioClip[11]);
            notesT[5].localScale = pos();
            break;
            case "F":
            audioSource.PlayOneShot (audioClip[9]);
            notesT[6].localScale = pos();
            break;
            case "D#":
            audioSource.PlayOneShot (audioClip[5]);
            notesT[7].localScale = pos();
            break;
            case "C#":
            audioSource.PlayOneShot (audioClip[3]);
            notesT[8].localScale = pos();
            break;
            case "A#":
            audioSource.PlayOneShot (audioClip[0]);
            notesT[9].localScale = pos();
            break;
            case "G#":
            audioSource.PlayOneShot (audioClip[10]);
            notesT[10].localScale = pos();
            break;
            case "F#":
            audioSource.PlayOneShot (audioClip[8]);
            notesT[11].localScale = pos();
            break;

            case "E2":
            audioSource.PlayOneShot (audioClip[7]);
            notesT[12].localScale = pos();
            break;
            case "D2":
            audioSource.PlayOneShot (audioClip[6]);
            notesT[13].localScale = pos();
            break;
            case "C2":
            audioSource.PlayOneShot (audioClip[4]);
            notesT[14].localScale = pos();
            break;
            case "B2":
            audioSource.PlayOneShot (audioClip[2]);
            notesT[15].localScale = pos();
            break;
            case "A2":
            audioSource.PlayOneShot (audioClip[1]);
            notesT[16].localScale = pos();
            break;
            case "G2":
            audioSource.PlayOneShot (audioClip[11]);
            notesT[17].localScale = pos();
            break;
            case "F2":
            audioSource.PlayOneShot (audioClip[9]);
            notesT[18].localScale = pos();
            break;
            case "D#2":
            audioSource.PlayOneShot (audioClip[5]);
            notesT[19].localScale = pos();
            break;
            case "C#2":
            audioSource.PlayOneShot (audioClip[3]);
            notesT[20].localScale = pos();
            break;
            case "A#2":
            audioSource.PlayOneShot (audioClip[0]);
            notesT[21].localScale = pos();
            break;
            case "G#2":
            audioSource.PlayOneShot (audioClip[10]);
            notesT[22].localScale = pos();
            break;
            case "F#2":
            audioSource.PlayOneShot (audioClip[8]);
            notesT[23].localScale = pos();
            break;
            
        }
    }

    private Vector3 pos(){
        return new Vector3 (1,0.95f,1);
    }
}
