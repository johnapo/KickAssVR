using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFollow : MonoBehaviour
{
    public GameObject hand;
    private BoxCollider box;
    

    // Start is called before the first frame update
    void Start()
    {
        box = hand.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        box.center.Set(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z);
    }
}
