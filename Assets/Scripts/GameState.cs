using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public int maxDogPass = 500;
    public const string ENEMY_TAG = "Dogs";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(ENEMY_TAG))
        {
            hitCount++;
        }
        if (hitCount >= maxDogPass)
        {
            Debug.Log("Game Ovah");
            Time.timeScale = 0f;

        }
    }
}
