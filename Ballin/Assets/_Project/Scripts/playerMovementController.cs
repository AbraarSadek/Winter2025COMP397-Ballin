/*
 * 
 * Script Name: playerMovementController
 * Created By: Abraar Sadek
 * Date Created: 02/10/2025
 * Last Modified: 02/10/2025
 * 
 * Script Purpose: To control the basic movement of the player, forward, backword, left and right...
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//playerMovementController Class
public class playerMovementController : MonoBehaviour {

    //Public Variables
    public float movementSpeed = 5f; //Float variable that will control the movement speed of the player
    public float stopLinearDamping = 1f; //Float variable that will control the 'Drag' of the player when it is not moving
    public float movementLinearDamping = 0f; //Float variable that will control the 'Drag' of the player when it is moving

    //Private Variables
    private Rigidbody rb; //Rigidbody variable referencing the 'Rigidbody' component attached to the player
    private float horizontalInput; //Will hold how much input is being sent for the player's horizontal input keys
    private float verticalInput; //Will hold how much input is being sent for the player's vertical input keys

    //Awake Method - Called when the script is loaded
    private void Awake() {
        rb = GetComponent<Rigidbody>(); //Get the 'Rigidbody' component attached to the player
        rb.linearDamping = stopLinearDamping; //Set the 'Drag' of the player to the value of the 'stopLinearDamping' variable
    } //End of Awake Method

    //FixedUpdate Method - Called once per frame
    void FixedUpdate() {

        //Get The Input From The Player (WASD or Arrow keys)
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput * movementSpeed, 0, verticalInput * movementSpeed); //Calculate the movement of the player

        //If-Else Statement - To Check If The Player Is Moving Or Not
        if (movement.magnitude > 0f)
        {
            rb.linearDamping = movementLinearDamping; //Set the 'Drag' of the player to the value of the 'movementLinearDamping' variable
            rb.AddForce(movement * movementSpeed, ForceMode.Acceleration); //Apply force to the Rigidbody to move the player
        } else {
            rb.linearDamping = stopLinearDamping; //Set the 'Drag' of the player to the value of the 'stopLinearDamping' variable
        } //End of If-Else Statement

    } //End of FixedUpdate Method

} //End of playerMovementController Class
