using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MachinePrompt : MonoBehaviour
{
    // Start is called before the first frame update
    void GameScene()
    {
        SceneManager.LoadScene("Machine"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            GameScene();
        }
    }
}
