using UnityEngine;

namespace Version_27 // Ensure this matches your VReqDV version folder name exactly!
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
            VReqDV.StateAccessor.SetState(obj.name, "rolling", obj, "Version_27");
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
            VReqDV.StateAccessor.SetState(obj.name, "red", obj, "Version_27");
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
            VReqDV.StateAccessor.SetState(obj.name, "green", obj, "Version_27");
        }

        // ACTION: Slides the door open (to the right, away from the table)
        public static void SlideDoorOpen(GameObject obj)
        {
            // Move the door right by its width (7.22 + 2.48 = 9.70)
            obj.transform.position = new Vector3(9.70f, 0.39f, 0f);
            
            // Tell VReqDV the state has changed to open
            VReqDV.StateAccessor.SetState(obj.name, "open", obj, "Version_27");
        }

        // ACTION: Slides the door closed (back to its original spot)
        public static void SlideDoorClosed(GameObject obj)
        {
            // Return the door to its original center position
            obj.transform.position = new Vector3(7.22f, 0.39f, 0f);
            
            // Tell VReqDV the state has changed to closed
            VReqDV.StateAccessor.SetState(obj.name, "closed", obj, "Version_27");
        }

        // CONDITION: Returns true if the left mouse button is currently being held down
        public static bool IsMouseHeld(GameObject obj)
        {
            return Input.GetMouseButton(0);
        }

        // CONDITION: Returns true on the exact frame the left mouse button is released
        public static bool IsMouseReleased(GameObject obj)
        {
            return Input.GetMouseButtonUp(0);
        }

        // ACTION: Prepares the object to be dragged
        public static void StartGrab(GameObject obj)
        {
            // Turn on kinematic so gravity/collisions don't rip it out of our hands
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null) rb.isKinematic = true;

            VReqDV.StateAccessor.SetState(obj.name, "grabbed", obj, "Version_27");
        }

        // ACTION: Moves the object to follow the mouse cursor
        public static void DragObject(GameObject obj)
        {
            // Find the object's current distance from the camera so it doesn't fly into our face
            float zDistance = Camera.main.WorldToScreenPoint(obj.transform.position).z;
            
            // Get mouse position and apply that depth
            Vector3 mouseScreenPos = Input.mousePosition;
            mouseScreenPos.z = zDistance;

            // Convert to 3D space and move the object
            obj.transform.position = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        }

        // ACTION: Drops the object back into the physics simulation
        public static void StopGrab(GameObject obj)
        {
            // Turn kinematic back off so it falls and rolls
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null) rb.isKinematic = false;

            VReqDV.StateAccessor.SetState(obj.name, "free", obj, "Version_27");
        }
    }
}
