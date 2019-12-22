using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartFunction : MonoBehaviour
{
  void Update()
  {

    if (Input.GetKeyDown("space"))
    {
      SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
  }
}
