using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YovanStankovic
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.
        [SerializeField] private SpriteRenderer spriteRenderer; // Our character's sprite.
        private LayerMask groundLayerMask;

        [SerializeField] private Rigidbody2D rbody2D; //rigidbody reference when coding physics

        [SerializeField] private float runSpeed = 3f; //declare the speed of the character

        [SerializeField] private float jumpStrength = 5f; //declare jump height of the character

        private bool isJumping = false; //variable for the jump command


        private void Update()
        {

            horizontalInputValue = Input.GetAxisRaw("Horizontal"); //

            //spriterender that changes where the sprite is looking on the x axis
            if (horizontalInputValue < 0f && spriteRenderer.flipX == true)
            {
                spriteRenderer.flipX = false;
            }

            else if (horizontalInputValue > 0f && spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
            }

            transform.position += new Vector3(horizontalInputValue * runSpeed, 0, 0) * Time.deltaTime; //

            isJumping = Input.GetButtonDown("Jump"); //

            if (isJumping) //if statement so the character can jump
            {
                rbody2D.velocity = Vector2.up * jumpStrength; //calling on the jumpStrength variable to make the jump
            }

        }
    }
}
