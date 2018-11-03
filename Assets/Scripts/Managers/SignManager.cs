using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignManager : MonoBehaviour {
    private const int signCount = 3;
    public GameObject a, b, c;
    private GameObject[] signs = new GameObject[signCount];

	// Use this for initialization
	void Start () {
        signs[0] = a;
        signs[1] = b;
        signs[2] = c;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetOnOff(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    public void OnA()
    {
        SetOnOff(a);
    }

    public void OnB()
    {
        SetOnOff(b);
    }

    public void OnC()
    {
        SetOnOff(c);
    }
}
