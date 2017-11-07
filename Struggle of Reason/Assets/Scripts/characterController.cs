using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float speed = 4.0f;
    public gameManager energySliderController;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
            energySliderController.curMoveState = true;
        else
            energySliderController.curMoveState = false;

        float translation = Input.GetAxis("Vertical") * speed;
        float strafe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
        else if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
