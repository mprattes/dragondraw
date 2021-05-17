using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string nomeDaCena;
    
    public void game()
    {
        SceneManager.LoadScene("Level01");
    }

    public void ChangeS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
	public void Sair()
    {
        Application.Quit();
    }
	
    public void fim()
    {
        SceneManager.LoadScene("Menu");
    }
	
  
}
