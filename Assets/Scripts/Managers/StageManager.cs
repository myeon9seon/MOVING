using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

    private const int stageCount = 2;
    //public enum Stage { Circle, Rectangle };

    public GameObject circle, rectangle;
    private GameObject[] stages = new GameObject[stageCount];

    public void Start()
    {
        stages[0] = circle;
        stages[1] = rectangle;
    }

	public void OnCircleStage()
    {
        OnOffStage(0);
    }

    public void OnRectangleStage()
    {
        OnOffStage(1);
    }

    private void OnOffStage(int curStage)
    {
        for (int i = 0; i < stageCount; i++)
        {
            if (i == curStage)
                stages[i].SetActive(true);
            else
                stages[i].SetActive(false);
        }
    }
}
