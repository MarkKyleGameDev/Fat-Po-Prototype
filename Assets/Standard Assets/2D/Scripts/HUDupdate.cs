using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDupdate : MonoBehaviour {

    public Image Burger = null;
    public Image Cheese = null;
    public Image Bun = null;
    public Image Teapot0 = null;
    public Image Teapot1 = null;
    public Image BoxCutter1 = null;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if(GameVariables.burger)
            Burger.GetComponent<Image>().enabled = true;
        if(GameVariables.cheese)
            Cheese.GetComponent<Image>().enabled = true;
        if(GameVariables.bun)
            Bun.GetComponent<Image>().enabled = true;
        if(GameVariables.teapot)
        {
            Teapot0.GetComponent<Image>().enabled = false;
            Teapot1.GetComponent<Image>().enabled = true;
        }
        if (GameVariables.key)
            BoxCutter1.GetComponent<Image>().enabled = true;
    }
}
