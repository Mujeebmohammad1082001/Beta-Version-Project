using UnityEngine;
using System.Collections;
using UnityEditor.UI;

public class ApplicationManager : MonoBehaviour {

	public GameObject instructionUI;

	public void instruction() 
	{
		if(instructionUI.activeInHierarchy == false)
		{
			instructionUI.SetActive(true);
		}

		else
		{
			instructionUI.SetActive(false);
		}

		/*#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif*/
	}
}
