using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigateToScene : MonoBehaviour
{

    //public string level;
    public void loadScene(string level) {
        SceneManager.LoadScene(level);
    }
}
