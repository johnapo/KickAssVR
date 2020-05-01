using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public GameObject HeadTrigger;
    public GameObject GroinTrigger;
    public GameObject LeftHandTrigger;
    public GameObject RightHandTrigger;
    public GameObject AbsTrigger;
    public GameObject ChestTrigger;
    public GameObject LeftArmTrigger;
    public GameObject RightArmTrigger;

    public GameObject HeadText;
    public GameObject GroinText;
    public GameObject LeftHandText;
    public GameObject RightHandText;
    public GameObject AbsText;
    public GameObject ChestText;
    public GameObject LeftArmText;
    public GameObject RightArmText;
    public GameObject hpText;

    public Slider healthBar;
    private int eHP = 500;
    private int headCtr = 0, groinCtr = 0, handCtr = 0, armCtr = 0, absCtr = 0, chCtr = 0;

    void Awake()
    {
     //   healthBar = GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        hpText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        hpText.GetComponent<Text>().text = eHP.ToString() + "/500";
        healthBar.value = eHP;
        if(healthBar.value <= 0)
        {
            eHP = 500;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == HeadTrigger)
        {
            Debug.Log("HeadHit");
            /*// Text fields for debugging in the in-game environment
            HeadText.SetActive(true);
            GroinText.SetActive(false);
            LeftHandText.SetActive(false);
            RightHandText.SetActive(false);
            AbsText.SetActive(false);
            ChestText.SetActive(false);
            LeftArmText.SetActive(false);
            RightArmText.SetActive(false);
            */
            eHP -= 80;
            headCtr++; 
        }

        if (other.gameObject == GroinTrigger)
        {
            Debug.Log("GroinHit");
            /*// Text fields for debugging in the in-game environment
            HeadText.SetActive(false);
            GroinText.SetActive(true);
            LeftHandText.SetActive(false);
            RightHandText.SetActive(false);
            AbsText.SetActive(false);
            ChestText.SetActive(false);
            LeftArmText.SetActive(false);
            RightArmText.SetActive(false);
            */
            eHP -= 60;
            groinCtr++;
        }

        if (other.gameObject == LeftHandTrigger || other.gameObject == RightHandTrigger)
        {
            Debug.Log("HandHit");
            HeadText.SetActive(false);
            GroinText.SetActive(false);
            LeftHandText.SetActive(true);
            RightHandText.SetActive(true);
            AbsText.SetActive(false);
            ChestText.SetActive(false);
            LeftArmText.SetActive(false);
            RightArmText.SetActive(false);
            eHP -= 10;
            handCtr++;
        }

        if (other.gameObject == LeftArmTrigger || other.gameObject == RightArmTrigger)
        {
            Debug.Log("ArmHit");
            HeadText.SetActive(false);
            GroinText.SetActive(false);
            LeftHandText.SetActive(false);
            RightHandText.SetActive(false);
            AbsText.SetActive(false);
            ChestText.SetActive(false);
            LeftArmText.SetActive(true);
            RightArmText.SetActive(true);
            eHP -= 30;
            armCtr++;
        }

        if (other.gameObject == AbsTrigger)
        {
            Debug.Log("AbsHit");
            HeadText.SetActive(false);
            GroinText.SetActive(false);
            LeftHandText.SetActive(false);
            RightHandText.SetActive(false);
            AbsText.SetActive(true);
            ChestText.SetActive(false);
            LeftArmText.SetActive(false);
            RightArmText.SetActive(false);
            eHP -= 40;
            absCtr++;
        }

        if (other.gameObject == ChestTrigger)
        {
            Debug.Log("ChestHit");
            HeadText.SetActive(false);
            GroinText.SetActive(false);
            LeftHandText.SetActive(false);
            RightHandText.SetActive(false);
            AbsText.SetActive(false);
            ChestText.SetActive(true);
            LeftArmText.SetActive(false);
            RightArmText.SetActive(false);
            eHP -= 20;
            chCtr++;
        }

    }


    }
