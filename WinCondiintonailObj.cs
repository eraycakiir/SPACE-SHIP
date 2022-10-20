using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondiintonailObj : MonoBehaviour
{
    [SerializeField] GameObject winCondintionalObj;
    private void Awake()
    {
        if (winCondintionalObj.activeSelf)
        {
            winCondintionalObj.SetActive(false);
        }
    }
    private void OnEnable()
    {
        GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
    }
    private void HandleOnMissionSucced()
    {
        if (!winCondintionalObj.activeSelf)
        {
            winCondintionalObj.SetActive(true);
        }
    }
  
}
