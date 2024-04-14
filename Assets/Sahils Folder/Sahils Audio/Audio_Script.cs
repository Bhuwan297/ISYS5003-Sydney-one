using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Script : MonoBehaviour
{
    public AudioSource Drop6;
    public AudioSource Rotate;
    public AudioSource Slider;
    public AudioSource Whale_shout;

    public void PlayDrop6() {
        Drop6.Play ();

    }

     public void PlayRotate() {
        Rotate.Play ();

    }
    
    public void PlaySlider() {
        Slider.Play ();

    }
    
    public void PlayWhale_shout() {
        Whale_shout.Play ();

    }
}
