using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPM : MonoBehaviour
{
    public int numberOfItems, score;
    public float health, weight, speed;
    public string dailogue, characterName, actuallyInterestedIn;
    public bool isEffectActive, isGrounded;
    public Vector2 size, PlayerLocation;
   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Master is interested in " + characterName);

        if (isGrounded)
        {
            Debug.Log("On the floor crying");
        }
        else
        {
            Debug.Log("Just kidding it's actually " + actuallyInterestedIn);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
