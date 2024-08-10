using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyFirstScript : MonoBehaviour
{ 
        public Button button;

    private void Start()
        {
        button.onClick.AddListener(OnButtonClick);
        }

    private void OnButtonClick()
    {
        Debug.Log("Button clicked");
        // Load the new scene
        SceneManager.LoadScene("First Scene"); // Replace "Scene1" with the actual name of your scene
    }
}
 