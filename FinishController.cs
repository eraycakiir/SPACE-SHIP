using SpaceShip.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    [SerializeField] GameObject finishFireLight;
    [SerializeField] GameObject finishLight;

    private void OnCollisionEnter(Collision other)
    {
        PlayerController playerController = other.collider.GetComponent<PlayerController>();
        if (playerController == null||playerController.CanMove) return;
        if (other.GetContact(0).normal.y == -1)
        {
            finishFireLight.SetActive(true);
            finishLight.SetActive(true);
            GameManager.Instance.MissionSucced();
        }
        else
        {
            //GameOver
            GameManager.Instance.GameOver();
        }
    }

}
