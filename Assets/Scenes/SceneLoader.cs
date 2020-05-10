using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Start()
    { 
        Debug.Log("testeroni pizzi on starti");
    }

    public void LoadScene(int level)
    { 
        SceneManager.LoadScene(level);
    }
}