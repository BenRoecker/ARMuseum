using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManagerCapcha : MonoBehaviour
{

    [Header("UI Element")]
    public Button m_infoButton;
    public Button m_hintButton;

    public GameObject m_textInfo;
    public GameObject m_textHint;

    public bool m_infoOn = false;
    public bool m_hintOn = false;

    // Start is called before the first frame update
    void Start()
    {
        m_infoButton.onClick.AddListener(InfoCanvasManager);
        m_hintButton.onClick.AddListener(HintCanvasManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfoCanvasManager()
    {
        if(m_infoOn == false)
        {
            m_textInfo.SetActive(true);
            m_infoOn = true;
        }
        else if(m_infoOn == true)
        {
            m_textInfo.SetActive(false);
            m_infoOn = false;
        }
    }

    public void HintCanvasManager()
    {
        if (m_hintOn == false)
        {
            m_textHint.SetActive(true);
            m_hintOn = true;
        }
        else if (m_hintOn == true)
        {
            m_textHint.SetActive(false);
            m_hintOn = false;
        }
    }
}
