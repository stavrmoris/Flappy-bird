using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScenes(int sceneId) => SceneManager.LoadScene(sceneId);
}
