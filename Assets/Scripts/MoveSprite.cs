using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSprite : MonoBehaviour {
    public GameObject sprite;
    
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        Debug.Log("is clicked!");
    }

    void OnMouseDrag()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        sprite.transform.position = worldPos;
        Debug.Log("is drag");
    }
}
