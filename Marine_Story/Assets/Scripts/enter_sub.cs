using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_sub : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;

    private bool isInsideVehicle;
    private SpriteRenderer spriteRenderer;
    public float enterDistance = 2.0f; // distance you are allowed to enter vehicle
    public GameObject target;//text object 

   void Start()
    {
        // Get the player's sprite renderer component
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, vehicle.transform.position); // calc the distance between vehicle and player
        if (Input.GetKeyDown(KeyCode.E) && distance <= enterDistance) // if player presses e and is close to the sub
        {
            if (isInsideVehicle)
            {
                ExitVehicle();
                spriteRenderer.enabled = true;
            }
            else
            {
                Destroy(target);// removes the text from screen

                spriteRenderer.enabled = false; // this hides the player sprite

                EnterVehicle();
            }
        }
        if (isInsideVehicle)
            {
                transform.position = player.transform.position; // this keeps the submarine on top of the player game object 
            }
        
    }

    void EnterVehicle()
    {
        isInsideVehicle = true; // boolean to keep track if player is in or is not in the vehicle 
    }

    void ExitVehicle()
    {
        isInsideVehicle = false;
    }
}
