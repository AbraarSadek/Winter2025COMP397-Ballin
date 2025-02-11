/*
 * 
 * Script Name: playerJumpController
 * Created By: Abraar Sadek
 * Date Created: 02/10/2025
 * Last Modified: 02/10/2025
 * 
 * Script Purpose: To control the basic upwards jump of the player...
 * 
 */

using UnityEngine;

//playerJumpController Class
public class playerJumpController : MonoBehaviour {

    //Public Variables
    public float jumpForce = 8f;  // Jump force
    public float raycastDistance = 1.1f; // Distance to check for ground
    public LayerMask groundLayer; // Define what is considered "ground"

    //Private Variables
    private Rigidbody rb;

    //Start Method
    void Start() {
        rb = GetComponent<Rigidbody>();
    } //End of Start Method

    //Update Method
    void Update() {
        //If-Statement - To Check If The Player Is On The Ground, And If So, Call The Jump Method
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
            Jump();
        } //End of If-Statement
    } //End of Update Method

    //Jump Method
    void Jump() {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z); // Reset Y velocity to prevent stacking forces
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    } //End of Jump Method

    //IsGrounded Method
    bool IsGrounded() {
        //Casts a ray downward to check if the ball is on the ground
        return Physics.Raycast(transform.position, Vector3.down, raycastDistance, groundLayer);
    } //End of IsGrounded Method

    //OnDrawGizmos Method
    void OnDrawGizmos() {
        // Visualizes the raycast in the scene view
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raycastDistance);
    } //End of OnDrawGizmos Method

} //End of playerJumpController Class

