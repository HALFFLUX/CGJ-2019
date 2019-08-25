using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePortalObj : MonoBehaviour
{
    public ScriptsChamber portal;
    [HideInInspector]
    public GameObject CurentScene;
    [HideInInspector]
    public GameObject NextScene;

    private void Start()
    {
        SaveNextAndCurentScene();
    }

    void SaveNextAndCurentScene()
    {
        CurentScene = GameObject.Find(portal.CurentScene);
        NextScene = GameObject.Find(portal.NextScene);
    }
}
