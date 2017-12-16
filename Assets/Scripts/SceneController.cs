/**
  * @file : SceneController.cs
  * @author : 임현 (hyunzion@gmail.com)
  * @since : 2017 - 12 - 16
  * @brief : Scene들을 관리
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public void ReturnMain()
	{
		SceneManager.LoadScene("Morning_Running");
	}

	public void ReturnBicycle()
	{
		SceneManager.LoadScene("Bicycle");
	}

	public void ReturnSetUp()
	{
		SceneManager.LoadScene("SetUp");
	}

	public void ReturnStory()
	{
		SceneManager.LoadScene("Story");
	}
}
