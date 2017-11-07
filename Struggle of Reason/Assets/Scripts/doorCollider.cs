using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorCollider : MonoBehaviour {

    public Text tooltips;

	void OnTriggerEnter()
    {
        tooltips.text = "Press E to Answer the Door";
        tooltips.gameObject.SetActive(true);
    }

    void OnTriggerExit()
    {
        tooltips.gameObject.SetActive(false);
    }
}
