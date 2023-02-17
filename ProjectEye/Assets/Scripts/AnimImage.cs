using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimImage : MonoBehaviour
{
    public static AnimImage Instance;
    void Awake()
    {
        Instance = this;
    }

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnim()
    {
        anim.SetTrigger("Play");
    }

}
