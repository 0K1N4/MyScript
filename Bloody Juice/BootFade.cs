using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CBootFade : MonoBehaviour
{
	public CFadeManager fadeManager; 
	private string currentSceneName;
   //private PlayerAction m_Input; // 入力管理用のPlayerAction

	void Start()
	{
		currentSceneName = SceneManager.GetActiveScene().name; 
	}

	// Update is called once per frame
	void Update()
	{
		if (currentSceneName == "Title"|| currentSceneName == "GAMEOVER"|| currentSceneName == "GAMECLEAR")
		{
			if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Joystick1Button0))
			{
					fadeManager.StartFadeOut();
			}
		}
	}
}
