using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillBarrier : MonoBehaviour
{
  public string name;
  void OnTriggerEnter2D(Collider2D col)
  {
    name = col.gameObject.name;

    Destroy(col.gameObject);
    if (name == "Soy Boy")
    {
      GetComponent<GameOverScreen>().gameOver();
    }
  }
}
