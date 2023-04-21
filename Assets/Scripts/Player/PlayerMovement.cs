using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody myBody;
    [SerializeField] float speed;
    Vector2 vectorMove = Vector2.zero;

    private void FixedUpdate()
    {
        vectorMove.x = Input.GetAxisRaw("Horizontal");
        vectorMove.y = Input.GetAxisRaw("Vertical");
        myBody.velocity = new Vector3(vectorMove.x * speed * Time.deltaTime, myBody.velocity.y, vectorMove.y * speed * Time.deltaTime);
    }
}
