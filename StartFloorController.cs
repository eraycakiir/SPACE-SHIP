using SpaceShip.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFloorController : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        PlayerController playerController = other.collider.GetComponent<PlayerController>();
        if (playerController != null)
        {
            Destroy(gameObject, 1f);
        }
    }
}
