using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScreen : MonoBehaviour
{
  public void gameOver()
  {
    GameObject.Find("GameOverText").GetComponent<Text>().enabled = true;
    GameObject.Find("GameOverText").GetComponent<RestartFunction>().enabled = true;
  }
}
