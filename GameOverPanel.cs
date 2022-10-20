using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
   public void YesClicked()
    {
        GameManager.Instance.LoadLevelScene();
    }
    public void NoClicked()
    {
        GameManager.Instance.LoadMenuScene();
    }
}
