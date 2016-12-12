using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LogPanel : MonoBehaviour 
{
    private bool isOpened;

	// Use this for initialization
	void Start () 
    {

	}

    public void OnClick()
    {
        if (!isOpened)
        {
            this.gameObject.SetActive(true);
            isOpened = true;
        } else
        {
            this.gameObject.SetActive(false);
            isOpened = false;
        }
    }
}
