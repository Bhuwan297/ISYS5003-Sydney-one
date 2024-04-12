using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxPlayer : MonoBehaviour
{
    public AudioSource Waterdrop;
    public AudioSource Waterdrop2;

    public void PlayWaterdrop(){
        Waterdrop.Play();
    }

    public void PlayWaterdrop2(){
        Waterdrop2.Play();
    }
}
