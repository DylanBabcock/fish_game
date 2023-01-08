using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_sub : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;

    private bool isInsideVehicle;
    private SpriteRenderer spriteRenderer;

   void Start()
    {
        // Get the player's sprite renderer component
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isInsideVehicle)
            {
                ExitVehicle();
                spriteRenderer.enabled = true;
            }
            else
            {
                
                spriteRenderer.enabled = false;

                EnterVehicle();
            }
        }
        if (isInsideVehicle)
            {
                transform.position = player.transform.position;
            }
        
    }

    void EnterVehicle()
    {
        isInsideVehicle = true;
    }

    void ExitVehicle()
    {
        isInsideVehicle = false;
    }
}
