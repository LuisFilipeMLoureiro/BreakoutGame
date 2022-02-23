using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fontes: https://www.youtube.com/watch?v=8pFlnyfRfRc
//https://www.youtube.com/watch?v=na-a3lLB13Q


public class SoundManager : MonoBehaviour
{

    
    public static AudioClip punch, lifelost, background;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        punch = Resources.Load<AudioClip>("punch");
        lifelost = Resources.Load<AudioClip>("lifelost");
        
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public static void PlaySound (string clip){

            switch (clip){
                case "punch":
                    audioSrc.PlayOneShot (punch);
                break;
                case "lifelost":
                    audioSrc.PlayOneShot (lifelost);
                break;
            }
        }
    
}
