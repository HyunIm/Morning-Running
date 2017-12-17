/**
 * @file : SkillCotroller.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 스킬 컨트롤러
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MoneyController
{
	public void Water ()
	{
		gold += 1000;
	}

	public void Breath ()
	{
		credit += 10;
	}
}
