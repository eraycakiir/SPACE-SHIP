using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondinatioanal : MonoBehaviour
{
 public void YesClicked()
    {
        GameManager.Instance.LoadLevelScene(1);
    }
}
