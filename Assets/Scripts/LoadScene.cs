using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] int SceneId;

    public void LoadScenes()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneId);
    }
}
