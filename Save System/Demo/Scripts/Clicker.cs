using UnityEngine;

class Clicker : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Reference to the scoreManager singleton
        ScoreManager.Instance.AddScore(1);
    }
}
