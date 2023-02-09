using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
  // public int sceneName;
   public void Exit(){
      Application.Quit();
   }
   public void StartGame(){
      UnityEngine.SceneManagement.SceneManager.LoadScene("intro1");
      Debug.Log("Going to level 1");

   }
}
