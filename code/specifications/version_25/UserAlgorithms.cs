using UnityEngine;

namespace Version_25 // Ensure this matches your VReqDV version folder name exactly!
{
    public static class UserAlgorithms
    {

        // Tracks which objects have already run their startup logic
        private static System.Collections.Generic.HashSet<string> initializedObjects = new System.Collections.Generic.HashSet<string>();

        // CONDITION: Returns true only the very first time it is called for an object
        public static bool NeedsInitialization(GameObject obj)
        {
            if (!initializedObjects.Contains(obj.name))
            {
                initializedObjects.Add(obj.name);
                return true;
            }
            return false;
        }

        // Dictionary to track the exact frame an object was clicked
        private static System.Collections.Generic.Dictionary<string, int> lastClickedFrame = new System.Collections.Generic.Dictionary<string, int>();

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
                    if (hit.collider.gameObject == obj)
                    {
                        int currentFrame = Time.frameCount;

                        // If we already successfully registered a click for this object on this exact frame, return false to prevent double-firing
                        if (lastClickedFrame.ContainsKey(obj.name) && lastClickedFrame[obj.name] == currentFrame)
                        {
                            return false;
                        }

                        // Otherwise, record the click for this frame and return true
                        lastClickedFrame[obj.name] = currentFrame;
                        return true;
                    }
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
            VReqDV.StateAccessor.SetState(obj.name, "rolling", obj, "Version_25");
        }

        // ACTION: Changes material to Red and updates state
        public static void SetColorRed(GameObject obj)
        {
            // Change the physical Unity material color
            UnityEngine.Renderer renderer = obj.GetComponent<UnityEngine.Renderer>();
            if (renderer != null)
            {
                renderer.material.color = UnityEngine.Color.red;
            }

            // Tell VReqDV the state has successfully changed
            VReqDV.StateAccessor.SetState(obj.name, "red", obj, "Version_25");
        }

        // ACTION: Changes material to Green and updates state
        public static void SetColorGreen(GameObject obj)
        {
            // Change the physical Unity material color
            UnityEngine.Renderer renderer = obj.GetComponent<UnityEngine.Renderer>();
            if (renderer != null)
            {
                renderer.material.color = UnityEngine.Color.green;
            }

            // Tell VReqDV the state has successfully changed
            VReqDV.StateAccessor.SetState(obj.name, "green", obj, "Version_25");
        }
    }
}
