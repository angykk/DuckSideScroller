using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ReloadGame : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(onClick);
        
    }

void onClick(){
		SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
	}

}
