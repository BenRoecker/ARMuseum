using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    #region value
    [SerializeField] GameObject cubeResult;
    [SerializeField] GameObject OldSphere;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        cubeResult.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResult()
    {
        OldSphere.SetActive(false);
        cubeResult.SetActive(true);
    }
}
