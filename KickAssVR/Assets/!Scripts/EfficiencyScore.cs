using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfficiencyScore : MonoBehaviour
{
    //Declare Variables
    int points = 0;
    int Ehp = 500;
    int Php = 500;
    int e_ribCtr = 0, e_faceCtr = 0, e_pitCtr = 0, e_armCtr = 0, e_blockCtr = 0, e_groinCtr = 0;
    int p_ribCtr = 0, p_faceCtr = 0, p_pitCtr = 0, p_armCtr = 0, p_blockCtr = 0, p_groinCtr = 0;
    int totalEnemyHits = 0;
    int totalEnemyDamage = 0;
    int totalPlayerHits = 0;
    int totalPlayerDamage = 0;
    public Text e_ribHitCounter;
    public Text e_faceHitCounter;
    public Text e_pitHitCounter;
    public Text e_armHitCounter;
    public Text e_handHitCounter;
    public Text e_groinHitCounter;
    public Text p_ribHitCounter;
    public Text p_faceHitCounter;
    public Text p_pitHitCounter;
    public Text p_armHitCounter;
    public Text p_handHitCounter;
    public Text p_groinHitCounter;
    public Text totalEnemyHitsCounter;
    public Text totalEnemyDamageCounter;
    public Text totalPlayerHitsCounter;
    public Text totalPlayerDamageCounter;
    public Text totalPointsCounter;

    //Detects when the object enters a collider marked as "trigger"
    private void OnTriggerEnter(Collider other)
    {
        //If-else statement used to determine what enemy trigger collider was hit, then adds to the respective counter and deducts enemy HP
        if (other.gameObject.name == "e_RibsHitBox") {
            e_ribCtr = e_ribCtr + 1;
            Ehp = Ehp - 40;
        }
        if (other.gameObject.name == "e_FaceHitBox")
        {
            e_faceCtr = e_faceCtr + 1;
            Ehp = Ehp - 80;
        }
        if (other.gameObject.name == "e_PitHitBox")
        {
            e_pitCtr = e_pitCtr + 1;
            Ehp = Ehp - 20;
        }
        if (other.gameObject.name == "e_ArmsHitBox")
        {
            e_armCtr = e_armCtr + 1;
            Ehp = Ehp - 30;
        }
        if (other.gameObject.name == "e_GroinHitBox")
        {
            e_groinCtr = e_groinCtr + 1;
            Ehp = Ehp - 60;
        }
        if (other.gameObject.name == "e_HandHitBox")
        {
            e_blockCtr = e_blockCtr + 1;
            Ehp = Ehp - 10;
        }

        //If-else statement used to determine what player trigger collider was hit, then adds to the respective counter and deducts enemy HP
        if (other.gameObject.name == "p_RibsHitBox")
        {
            p_ribCtr = p_ribCtr + 1;
            Php = Php - 40;
        }
        if (other.gameObject.name == "p_FaceHitBox")
        {
            p_faceCtr = p_faceCtr + 1;
            Php = Php - 80;
        }
        if (other.gameObject.name == "p_PitHitBox")
        {
            p_pitCtr = p_pitCtr + 1;
            Php = Php - 20;
        }
        if (other.gameObject.name == "p_ArmsHitBox")
        {
            p_armCtr = p_armCtr + 1;
            Php = Php - 30;
        }
        if (other.gameObject.name == "p_GroinHitBox")
        {
            p_groinCtr = p_groinCtr + 1;
            Php = Php - 60;
        }
        if (other.gameObject.name == "p_HandHitBox")
        {
            p_blockCtr = p_blockCtr + 1;
            Php = Php - 10;
        }

    }

    //Constantly updates scene 60 times a second
    void Update()
    {
        //Calculates the score by adding all the counters up times their respective individual point values
        points = (e_faceCtr * 80) + (e_armCtr * 30) + (e_pitCtr * 20) + (e_blockCtr * 10) + (e_groinCtr * 60) + (e_ribCtr * 40);
        totalEnemyHits = e_faceCtr + e_ribCtr + e_groinCtr + e_blockCtr + e_armCtr + e_pitCtr;
        totalPlayerHits = p_faceCtr + p_ribCtr + p_groinCtr + p_blockCtr + p_armCtr + p_pitCtr;
        totalEnemyDamage = 500 - Ehp;
        totalPlayerDamage = 500 - Php;

        //Counters that will update the enemy data every time a new hit comes into contact with the enemy
        e_ribHitCounter.text = "Rib Hits:     " + e_ribCtr;
        e_faceHitCounter.text = "Face Hits:       " + e_faceCtr;
        e_pitHitCounter.text = "Pit Hits:     " + e_pitCtr;
        e_armHitCounter.text = "Arm Hits:     " + e_armCtr;
        e_handHitCounter.text = "Hand Hits:       " + e_blockCtr;
        e_groinHitCounter.text = "Groin Hits:     " + e_groinCtr;
        totalEnemyHitsCounter.text = "Enemy Total" + "\n" + "Hits:        " + totalEnemyHits;
        totalEnemyDamageCounter.text = "Enemy Total" + "\n" + "Damage:        " + totalEnemyDamage;
        totalPointsCounter.text = "Total" + "\n" + "Points:        " + points;

        //Counters that will update the player data every time a new hit comes into contact with the player
        p_ribHitCounter.text = "Rib Hits:     " + p_ribCtr;
        p_faceHitCounter.text = "Face Hits:       " + p_faceCtr;
        p_pitHitCounter.text = "Pit Hits:     " + p_pitCtr;
        p_armHitCounter.text = "Arm Hits:     " + p_armCtr;
        p_handHitCounter.text = "Hand Hits:       " + p_blockCtr;
        p_groinHitCounter.text = "Groin Hits:     " + p_groinCtr;
        totalPlayerHitsCounter.text = "Player Total" + "\n" + "Hits:        " + totalPlayerHits;
        totalPlayerDamageCounter.text = "Player Total" + "\n" + "Damage:        " + totalPlayerDamage;
        

    }
}
