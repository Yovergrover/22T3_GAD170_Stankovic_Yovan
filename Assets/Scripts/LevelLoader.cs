using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YovanStankovic
{

    public class LevelLoader : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                LoadLevel("WeekTwoActivities");
            }
        }

        /// <summary>
        /// This will load a different scene.
        /// </summary>
        private void LoadLevel(string SceneToLoad)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}

