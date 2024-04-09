using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxPlayer : MonoBehaviour
{
  public AudioSource src;
  public AudioClip sfx1, sfx2;

  public void Button1()
{
    src.clip = sfx1;
}

public void Button2()
{
    src.clip = sfx2;
}
}
