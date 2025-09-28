using UnityEngine;

public class MoveMaze : MonoBehaviour
{
    Vector3 current_tilt = Vector3.up;
    public float rotation_speed = 30.0f;
    public float tilt_limit = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation = Input.GetAxis("Vertical") * Time.deltaTime * rotation_speed;
        float zRotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotation_speed;

        current_tilt.x = Mathf.Clamp(current_tilt.x, -tilt_limit, tilt_limit);
        current_tilt.y = Mathf.Clamp(current_tilt.y, -tilt_limit, tilt_limit);

        transform.rottation = Quaternion.Euler(current_tilt);
    }
}
