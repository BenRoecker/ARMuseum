using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManagerCapcha : MonoBehaviour
{

    [Header("UI Element")]
    public Button m_backToCurrentTimeButton;
    public Button m_infoButton;
    public Button m_hintButton;

    public GameObject m_canvasInfo;
    public GameObject m_canvasHint;

    public string m_startScenen;

    [Header("UI Solve")]
    public Button m_backToCurrentTimeSolveButton;

    public bool m_infoOn = false;
    public bool m_hintOn = false;

    // Start is called before the first frame update
    void Start()
    {
        m_backToCurrentTimeButton.onClick.AddListener(BackToCurrentTime);
        m_backToCurrentTimeSolveButton.onClick.AddListener(BackToCurrentTime);
        m_infoButton.onClick.AddListener(InfoCanvasManager);
        m_hintButton.onClick.AddListener(HintCanvasManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToCurrentTime()
    {
        SceneManager.LoadScene(m_startScenen);
    }

    public void InfoCanvasManager()
    {
        if(m_infoOn == false)
        {
            m_canvasInfo.SetActive(true);
            m_infoOn = true;
        }
        else if(m_infoOn == true)
        {
            m_canvasInfo.SetActive(false);
            m_infoOn = false;
        }
    }

    public void HintCanvasManager()
    {
        if (m_hintOn == false)
        {
            m_canvasHint.SetActive(true);
            m_hintOn = true;
        }
        else if (m_hintOn == true)
        {
            m_canvasHint.SetActive(false);
            m_hintOn = false;
        }
    }
}
