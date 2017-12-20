using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    //public float speed = 6.0F;
    //public float jumpSpeed = 8.0F;
    //public float gravity = 20.0F;
    //private Vector3 moveDirection = Vector3.zero;
    //public CharacterController controller;
    //public Transform target;
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}