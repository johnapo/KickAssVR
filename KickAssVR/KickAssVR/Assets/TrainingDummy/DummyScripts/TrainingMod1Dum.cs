using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using System.Collections;


//Hypothetical code if a blend was used in the animator state machine
//By: Jestin Griffes

public class TrainingMod1Dum : MonoBehaviour
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
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("DummyIdle") || anim.GetCurrentAnimatorStateInfo(0).IsName("RPunch"))
        {
            return;
        }

        //Runs through the idle animation three times
        if(i <= 3)
        {
            i++;
        }

        //If there was a blend in the state machine, turn the parameter to 1 so that the RPunch animation is triggered.
        else
        {
            anim.SetFloat("Action", 1);            
            i = 0;
        }
    }
}
