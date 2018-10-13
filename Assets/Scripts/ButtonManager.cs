using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public GameObject Ribbon;

    public void OnRibbonMenu()
    {
        Ribbon.SetActive(!Ribbon.activeSelf);
    }
}
