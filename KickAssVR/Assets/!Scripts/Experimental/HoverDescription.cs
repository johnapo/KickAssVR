using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverDescription : MonoBehaviour
{
    public GameObject descriptiveText;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        
            descriptiveText.SetActive(true);
        
    }

    private void OnMouseExit()
    {
 
            descriptiveText.SetActive(false);
        
    }
}
