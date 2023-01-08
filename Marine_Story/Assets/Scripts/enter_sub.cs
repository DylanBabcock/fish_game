using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_sub : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;

    private bool isInsideVehicle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isInsideVehicle)
            {
                ExitVehicle();
            }
            else
            {
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
