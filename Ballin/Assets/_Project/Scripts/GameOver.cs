using UnityEngine;

namespace Platformer397
{
    public class GameOver : MonoBehaviour
    {
        public string gameOverSceneName = "DeathScene";
        public GameObject Player;
        private Vector3 playerPosition;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");

            if (Player == null)
            {
                Debug.LogError("Player not found in the scene. Please add a player to the scene.");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Player != null)
            {
                playerPosition = Player.transform.position;
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
