using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_controller : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>();
        //m_Rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    // Update is called once per frame
    void Update()
    {        

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0, speed* vertical, 0);
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        if (vertical != 0) {
            transform.Rotate(new Vector3(0f, 0f, -rotation*vertical));
        }
        else {
            transform.Rotate(new Vector3(0f, 0f, -rotation));
        }
    }
}
