using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class enter_sub : MonoBehaviour
{
    // The player character's transform
    public Transform player;

    // The vehicle's transform
    public Transform vehicle;

    // A UI text object to display instructions to the player
    public Text instructions;

    // A flag to track whether the player is currently inside the vehicle
    private bool isInsideVehicle = false;

    // Update is called once per frame
    void Update()
    {
        // If the player is inside the vehicle, allow them to exit
        if (isInsideVehicle)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ExitVehicle();
            }
        }
    }

    // Handle the player entering the trigger
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if the collider belongs to the player character
        if (collider.transform == player)
        {
            // Display instructions to the player
            instructions.text = "Press 'E' to enter the vehicle.";
        }
    }

    // Handle the player exiting the trigger
    void OnTriggerExit2D(Collider2D collider)
    {
        // Check if the collider belongs to the player character
        if (collider.transform == player)
        {
            // Clear the instructions
            instructions.text = "";
        }
    }

    // Handle the player pressing the "enter" button
    void OnTriggerStay2D(Collider2D collider)
    {
        // Check if the collider belongs to the player character
        if (collider.transform == player)
        {
            // Check if the player pressed the "enter" button
            if (Input.GetKeyDown(KeyCode.E))
            {
                EnterVehicle();
            }
        }
    }

    // Enter the vehicle
    void EnterVehicle()
    {
        // Set the player's parent to the vehicle
        player.SetParent(vehicle);

        // Disable the player's collider and rigidbody
        player.GetComponent<Collider2D>().enabled = false;
        player.GetComponent<Rigidbody2D>().simulated = false;

        // Update the flag to indicate that the player is inside the vehicle
        isInsideVehicle = true;

        // Update the instructions
        instructions.text = "Press 'E' to exit the vehicle.";
    }

    // Exit the vehicle
    void ExitVehicle()
    {
        // Set the player's parent back to its original parent
        player.SetParent(null);

        // Enable the player's collider and rigidbody
        player.GetComponent<Collider2D>().enabled = true;
        player.GetComponent<Rigidbody2D>().simulated = true;

        // Update the flag to indicate that the player is no longer inside the vehicle
        isInsideVehicle = false;

        // Clear the instructions
        instructions.text = "";
    }
}
