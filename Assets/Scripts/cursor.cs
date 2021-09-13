using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
/*        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();*/
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePosition;
        MousePosition = Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
        transform.position = new Vector3(MousePosition.x, MousePosition.y, 0);
        Debug.Log(MousePosition);

    }

}
