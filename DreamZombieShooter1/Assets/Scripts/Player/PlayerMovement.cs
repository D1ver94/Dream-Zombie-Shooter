using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    Vector3 _Movement;
    Animator anim;
    Rigidbody _playerRb;
    int floorMask;
    float camReyLenght = 100f;

    void Awaike()
    {
        _floorMask = LayerMask.GetMask("floor");
        _anim = GetComponent < Animator >
        _playerRb = GetComponent<RigitBody>();
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Move(horizontalInput, verticalInput);
        Turning();

    }
    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalaized * speed * Time.deltatime;
        playerRb.MovePosition(transform.position + movement);
    }
    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(input.mouseposition);
        RaycastHit floorHit;

        if (phisics.Raycast(camRay, out floorHit, camRayLenght, floorMask)
        {
            Vector3 playerToMouse = floorHit.point = transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRb.MoveRotation(newRotation);
        }
    }
}
