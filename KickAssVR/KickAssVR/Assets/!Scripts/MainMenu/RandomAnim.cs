using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Chooses random animation to do based on array of animations
public class RandomAnim : MonoBehaviour
{
    public Animation[] arrAnim;
    private Animation anim;
    private int len;
    private int randInt;

    // Start is called before the first frame update
    void Start()
    {
        len = arrAnim.Length;
    }

    // Update is called once per frame
    void Update()
    {
        // Determines random index in animation arr and plays that animation
        randInt = Random.Range(0, len);
        anim.Play(arrAnim[randInt].name);
    }
}
