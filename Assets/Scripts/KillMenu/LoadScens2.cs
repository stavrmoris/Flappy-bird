using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScens2 : MonoBehaviour
{

    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
    

}
