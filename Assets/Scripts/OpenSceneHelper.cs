using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneHelper : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToOpen;

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToOpen);
    }
}
