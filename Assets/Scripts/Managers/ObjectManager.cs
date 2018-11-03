using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {
    private const int objectCount = 5;
    public GameObject obj1, obj2, obj3, obj4, boss;
    private GameObject[] objs = new GameObject[objectCount];

	// Use this for initialization
	void Start () {
        objs[0] = obj1;
        objs[1] = obj2;
        objs[2] = obj3;
        objs[3] = obj4;
        objs[4] = boss;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetOnOff(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    public void OnObj1()
    {
        SetOnOff(obj1);
    }

    public void OnObj2()
    {
        SetOnOff(obj2);
    }

    public void OnObj3()
    {
        SetOnOff(obj3);
    }

    public void OnObj4()
    {
        SetOnOff(obj4);
    }

    public void OnBoss()
    {
        SetOnOff(boss);
    }
}
