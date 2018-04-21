using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{

    private static bool _created = false;
    private Flowchart Flowchart;
    private bool result;
    private String sceneName;

    void Awake()
    {
        if (!_created)
        {
            DontDestroyOnLoad(this.gameObject);
            _created = true;
        }
    }
    

    public void loadVisualNovelScene(bool _result, string _sceneName)
    {
        result = _result;
        sceneName = _sceneName;
        StartCoroutine(loadScene());
    }

    IEnumerator loadScene()
    {
        var asyncLoadScene = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoadScene.isDone)
        {
            yield return null;
        }

        Flowchart flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        Debug.Log(flowchart.HasBlock("onWin"));
        flowchart.ExecuteBlock((result) ? "onWin" : "onLose");
    }
}
