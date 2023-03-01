using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : Singleton<ScenesManager>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void LancementApplication()
    {
        SceneManager.LoadScene(1);
    }

    public void EndTutoriel()
    {
        SceneManager.LoadScene(2);
    }
}
