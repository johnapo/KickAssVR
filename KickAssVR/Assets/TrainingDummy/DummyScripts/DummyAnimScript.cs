using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyAnimScript : MonoBehaviour
{
    Animator anim;
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if an animation is playing, if so, don't change animation
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("DummyIdle") || anim.GetCurrentAnimatorStateInfo(0).IsName("RPunch"))
        {
            return;
        }

        //Runs through the idle animation three times
        if (i <= 3)
        {
            i++;
        }

    }
}
