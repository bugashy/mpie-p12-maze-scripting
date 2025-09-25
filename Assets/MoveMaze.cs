using UnityEngine;

public class MoveMaze : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation = Input.GetAxis("Vertical") * Time.deltaTime * 30;
        float zRotation = Input.GetAxis("Horizontal") * Time.deltaTime * 30;

        transform.Rotate(xRotation, 0, zRotation);
    }
}
