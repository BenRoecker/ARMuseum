using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManagerCapcha : MonoBehaviour
{

    [Header("UI Element")]
    public Button m_backToCurrentTime;

    public string m_startScenen;

    [Header("UI Solve")]
    public Button m_backToCurrentTimeSolve;

    // Start is called before the first frame update
    void Start()
    {
        m_backToCurrentTime.onClick.AddListener(BackToCurrentTime);
        m_backToCurrentTimeSolve.onClick.AddListener(BackToCurrentTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToCurrentTime()
    {
        SceneManager.LoadScene(m_startScenen);
    }
}
