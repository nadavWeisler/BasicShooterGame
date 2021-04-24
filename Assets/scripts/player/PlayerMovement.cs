using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float acceleration;

    [SerializeField] 
    private float maxSpeed;

    private Rigidbody rigidbody;

    private readonly KeyCode[] inputKeys = { KeyCode.W, KeyCode.A, KeyCode.D, KeyCode.S };
    private readonly Vector3[] directions = { Vector3.forward, Vector3.left, Vector3.right, Vector3.back, };



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < inputKeys.Length; i++)
        {
            if (Input.GetKey(inputKeys[i]))
            {
                Vector3 movement = directions[i] * acceleration * Time.deltaTime;
                MovePlayer(movement);
            }
        }
    }

    private void MovePlayer(Vector3 movment)
    {
        if (rigidbody.velocity.magnitude * acceleration > maxSpeed)
        {
            rigidbody.AddForce(movment * -1);
        }
        else
        {
            rigidbody.AddForce(movment);
        }
    }


}
