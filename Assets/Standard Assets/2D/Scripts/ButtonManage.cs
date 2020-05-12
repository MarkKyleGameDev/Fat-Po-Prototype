using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class ButtonManage : MonoBehaviour {

	public void newGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

    //void Update()
    //{
    //    if (Input.GetKey("escape"))
    //        Application.Quit();
    //}
}
