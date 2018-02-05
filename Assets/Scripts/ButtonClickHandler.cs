using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour {


    public GameObject boyGameObject;
    //private Rigidbody2D rBody;
    public Sprite boySprite;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {
       
        sRend = boyGameObject.GetComponent<SpriteRenderer>();
    }
	void OnMouseDown()
    {
        //Debug.Log("Testing");
        //rBody = boyGameObject.GetComponent<Rigidbody2D>();
        sRend.sprite = boySprite;

    }
}
