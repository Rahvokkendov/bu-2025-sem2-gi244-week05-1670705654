using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMY_TAG = "Dogs";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(ENEMY_TAG))
        {
            hitCount++;
        }
        if (hitCount >= 500)
        {
            Debug.Log("Game Ovah");
            Time.timeScale = 0f;

        }
    }
}
