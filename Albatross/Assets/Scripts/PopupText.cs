using UnityEngine;
using System.Collections;

public class PopupText : MonoBehaviour {

    GameObject[] mayorObjects;

	// Use this for initialization
	void Start ()
    {
        mayorObjects = GameObject.FindGameObjectsWithTag("PopupText");
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    //Assigned to button; clicking will dismiss Mayor Text
    public void HideText()
    {
        foreach (GameObject go in mayorObjects)
        {
            go.SetActive(false);
        }
    }
}
