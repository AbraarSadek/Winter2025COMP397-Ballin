using UnityEngine;

namespace Platformer397
{
    public class GameOver : MonoBehaviour
    {
        public string gameOverSceneName = "DeathScene";
        public GameObject player;
        private Vector3 playerPosition;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");

            if (player == null)
            {
                Debug.LogError("Player not found in the scene. Please add a player to the scene.");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (player != null)
            {
                playerPosition = player.transform.position;
                if (playerPosition.y < -10)
                {
                    LoadDeath();
                }
            }
        }

        public void LoadDeath()
        {
            Time.timeScale = 1f;
            Debug.Log("Game Over");
            UnityEngine.SceneManagement.SceneManager.LoadScene(gameOverSceneName);
        }
    }
}
