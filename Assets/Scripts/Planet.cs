using UnityEngine;

public class Planet : MonoBehaviour {
    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}