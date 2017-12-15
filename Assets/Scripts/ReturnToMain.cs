/**
  * @file : ReturnToMain.cs
  * @author : 임현 (hyunzion@gmail.com)
  * @since : 2017 - 12 - 15
  * @brief : Main(Morning_Running) Scene으로 돌아감
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMain : MonoBehaviour
{
	public void ReturnMain ()
	{
		SceneManager.LoadScene("Morning_Running");
	}
}
