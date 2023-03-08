using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScaleUpdate : MonoBehaviour
{
    public GameObject Image1 = null;
    public GameObject Image2 = null;
    Vector3 dist;
    float mod = 0;
    float min = 0.1f;
    [SerializeField] private TextMeshProUGUI textTuto;
    [SerializeField] private TextMeshProUGUI textTutoPlace;
    [SerializeField] private CanvasManagerTuto canvasManager;

    private void Start()
    {
        textTuto.transform.parent.gameObject.SetActive(false);
        textTutoPlace.transform.parent.gameObject.SetActive(false);
    }
    void Update()
    {
        textTuto.text = "Recherchez les cartes suivantes : ";
        textTutoPlace.text = "Rapprochez les cartes pour les fusionner";
        MarkDist Image1Position = Image1.GetComponent<MarkDist>();
        MarkDist Image2Position = Image2.GetComponent<MarkDist>();
        dist = Image1Position.delta - Image2Position.delta;
        if (Image1Position.goIn == false && Image2Position.goIn)
        {
            textTuto.text += "1";
        }
        else if(Image2Position.goIn == false && Image1Position.goIn)
        {
            textTuto.text += "2";
        }
        else if(Image2Position.goIn == false && Image1Position.goIn == false)
        {
            textTuto.text += "1 et 2";
        }
        if (Image1Position.goIn && Image2Position.goIn)
        {
            textTuto.transform.parent.gameObject.SetActive(false);
            textTutoPlace.transform.parent.gameObject.SetActive(true);
            mod = dist.magnitude;
            if(mod < min)
            {
                canvasManager.ShowResult();
            }
            Debug.Log("module" + mod);
        }
        else
        {
            textTuto.transform.parent.gameObject.SetActive(true);
        }
    }
}
