using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

    private const int stageCount = 2;
    //public enum Stage { Circle, Rectangle };

    public GameObject circle;
    public GameObject rectangle;

    private GameObject[] stages = new GameObject[stageCount];

    public void Start()
    {
        stages[0] = circle;
        stages[1] = rectangle;
    }

	public void OnCircleStage()
    {
        stages[0].SetActive(true);
        OffOtherStage(0);
    }

    public void OnRectangleStage()
    {
        stages[1].SetActive(true);
        OffOtherStage(1);
    }

    private void OffOtherStage(int curStage)
    {
        for (int i = 0; i < stageCount; i++)
        {
            if (i == curStage)
                continue;
            else
                stages[i].SetActive(false);
        }
    }
}
