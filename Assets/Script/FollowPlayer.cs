using UnityEngine;

namespace Assets.Script
{
    public class FollowPlayer : MonoBehaviour
    {
        public Transform player;
        Vector3 thirdView;

        void FixedUpdate()
        {
            thirdView.x = 0;
            thirdView.y = 1;
            thirdView.z = -5;
            this.transform.position = player.position + thirdView;
        }
    }
}
