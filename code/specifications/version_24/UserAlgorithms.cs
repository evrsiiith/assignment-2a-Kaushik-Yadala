using UnityEngine;

namespace Version_24 // Ensure this matches your VReqDV version folder name exactly!
{
    public static class UserAlgorithms
    {
        // CONDITION: Evaluates to true only on the frame this specific object is clicked
        public static bool IsObjectClicked(GameObject obj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Cast ray from camera to mouse position
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                // Check if we hit something AND if it is the object this behavior belongs to
                if (Physics.Raycast(ray, out hit))
                {
                    return hit.collider.gameObject == obj;
                }
            }
            return false;
        }

        // ACTION: Enables gravity and updates the VReqDV state
        public static void DropSphere(GameObject obj)
        {
            // Enable gravity on the Rigidbody
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.useGravity = true;
            }

            // Optional but recommended: Update the state machine so this action doesn't run twice
            VReqDV.StateAccessor.SetState(obj.name, "rolling", obj, "Version_1");
        }
    }
}
