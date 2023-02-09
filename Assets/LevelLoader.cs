using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public string sceneName;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter(seconds));
    }

    IEnumerator waiter(float seconds) {
        yield return new WaitForSeconds(seconds);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

}
