using UnityEngine;

public class JawControl : MonoBehaviour
{
    public GameObject child1; // Assign the first child GameObject in Unity Inspector
    public GameObject child2; // Assign the second child GameObject in Unity Inspector

    // Call this method when the 'Maxilla' button is pressed
    public void OnMaxillaPressed()
    {
        if(child1 != null)
        {
            // Toggle the active state of child1
            child1.SetActive(!child1.activeSelf);
        }
    }

    // Call this method when the 'Mandible' button is pressed
    public void OnMandiblePressed()
    {
        if(child2 != null)
        {
            // Toggle the active state of child2
            child2.SetActive(!child2.activeSelf);
        }
    }
}
