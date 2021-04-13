
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioClip clip1;
    [SerializeField]private AudioClip clip2;
    [SerializeField]private AudioClip clip3;
    [SerializeField]private AudioClip clip4;

    [SerializeField]private AudioClip ropeClip1;
    [SerializeField]private AudioClip ropeClip2;
    [SerializeField]private AudioClip ropeClip3;
    [SerializeField]private AudioClip ropeClip4;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    public void playRandomSound(){
        int sound = Random.Range(1, 4);

        if(sound == 1){
            audioSource.PlayOneShot(clip1);
        }else if(sound == 2){
            audioSource.PlayOneShot(clip2);
        }else if(sound == 3){
            audioSource.PlayOneShot(clip3);
        }else if(sound == 4){
            audioSource.PlayOneShot(clip4);
        }
    }

    public void playRandomRopeSound(){
        int sound = Random.Range(1, 4);

        if(sound == 1){
            audioSource.PlayOneShot(ropeClip1);
        }else if(sound == 2){
            audioSource.PlayOneShot(ropeClip2);
        }else if(sound == 3){
            audioSource.PlayOneShot(ropeClip3);
        }else if(sound == 4){
            audioSource.PlayOneShot(ropeClip4);
        }
    }
}
