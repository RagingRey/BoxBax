using UnityEngine;

namespace Assets.Script
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rb;

        public float sideMovement = 700f;
        public float forwardMovement = 400f;
        public float backWardMovement = -750f;

        void FixedUpdate()
        {
            rb.AddForce(0, 0, forwardMovement * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (Input.GetKey("a"))
            {
                rb.AddForce(-sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (Input.GetKey("w"))
            {

            }
            else if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, backWardMovement * Time.deltaTime);
            }
        }
    }
}
