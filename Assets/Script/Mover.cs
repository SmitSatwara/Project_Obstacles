using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed=10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal");
        float zVal = Input.GetAxis("Vertical");
        //float yVal = Input.GetAxis("Jump")*moveSpeed;
        transform.Translate(xVal * Time.deltaTime * moveSpeed, 0, zVal * Time.deltaTime * moveSpeed);

    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
    }
}
