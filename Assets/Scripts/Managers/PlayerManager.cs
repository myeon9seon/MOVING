using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    private const int playerCount = 8;
    public GameObject MT, ST, H1, H2, D1, D2, D3, D4;
    private GameObject[] players = new GameObject[playerCount];

	// Use this for initialization
	void Start () {
        players[0] = MT; players[1] = ST;
        players[2] = H1; players[3] = H2;
        players[4] = D1; players[5] = D2;
        players[6] = D3; players[7] = D4;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetOnOff(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    public void OnMT()
    {
        SetOnOff(MT);
    }

    public void OnST()
    {
        SetOnOff(ST);
    }

    public void OnH1()
    {
        SetOnOff(H1);
    }

    public void OnH2()
    {
        SetOnOff(H2);
    }

    public void OnD1()
    {
        SetOnOff(D1);
    }

    public void OnD2()
    {
        SetOnOff(D2);
    }

    public void OnD3()
    {
        SetOnOff(D3);
    }

    public void OnD4()
    {
        SetOnOff(D4);
    }
}
