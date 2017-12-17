/**
 * @file : ScreenController.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 18
 * @brief : 빌드 해상도 고정
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
	private void Awake()
	{
		Screen.SetResolution(Screen.width, Screen.width * 9 / 16, false);
	}
}
