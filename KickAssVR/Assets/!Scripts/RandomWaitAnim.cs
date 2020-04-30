using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWaitAnim : MonoBehaviour
{
    public Animator animator;
    public int randRangeMin, randRangeMax; //Range of time values to wait, min should be >= animation length
    public string anim;
    bool animationDone = true;

    void Update()
    {
        if (animationDone) StartCoroutine(WaitAnim());
    }

    //an IEnumerator that simply plays an anim after yielding a random amount of time
    public IEnumerator WaitAnim()
    {
        animationDone = false;
        int randomWait = Random.Range(randRangeMin, randRangeMax); //generate time to wait 
        print("Time" + randomWait + " Play");
        yield return new WaitForSeconds(randomWait); 
        animator.Play(anim);
        animationDone = true;
    }
}