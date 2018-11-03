using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 새 리본 추가할 때 Count++; ribbons에 초기화;

public class RibbonMenu : MonoBehaviour {
    private const int ribbonCount = 4;
    private enum RIBBON { STAGE, PLAYER, OBJ, SIGN };
    public GameObject ribbon;
    public GameObject stage, player, obj, sign;
    private GameObject[] ribbons = new GameObject[ribbonCount];

    private void Start()
    {
        ribbons[0] = stage;
        ribbons[1] = player;
        ribbons[2] = obj;
        ribbons[3] = sign;
    }

    private void OffOtherRibbon(int curRibbon)
    {
        for (int i = 0; i < ribbonCount; i++)
        {
            if (i == curRibbon)
                ribbons[i].SetActive(true);
            else
                ribbons[i].SetActive(false);
        }
    }

    private void OnRibbonMenu(int curRibbon)
    {
        if (!ribbons[curRibbon].activeSelf)
        {
            ribbon.SetActive(true);
            OffOtherRibbon(curRibbon);
        }
        else
        {
            ribbons[curRibbon].SetActive(false);
        }
    }
    
    public void OnRibbonStage()
    {
        OnRibbonMenu((int)RIBBON.STAGE);
    }

    public void OnRibbonPlayer()
    {
        OnRibbonMenu((int)RIBBON.PLAYER);
    }

    public void OnRibbonObject()
    {
        OnRibbonMenu((int)RIBBON.OBJ);
    }

    public void OnRibbonSign()
    {
        OnRibbonMenu((int)RIBBON.SIGN);
    }
}
