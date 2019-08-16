using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 0.2f,-10);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f, -10);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - 0.2f, this.gameObject.transform.position.y, -10);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + 0.2f, this.gameObject.transform.position.y, -10);
        }
    }
}
