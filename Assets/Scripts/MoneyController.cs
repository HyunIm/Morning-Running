 /**
  * @file : MoneyController.cs
  * @author : 임현 (hyunzion@gmail.com)
  * @since : 2017 - 12 - 16
  * @brief : 화폐 컨트롤러
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
	char gold_unit = 'a';
	char credit_unit = 'a';
	int gold = 1;
	int credit = 1;

	public Text goldLabel;
	public Text creditLabel;

	public void Update()
	{
		int g = CalcGold(gold);	// 골드
		int c = CalcCredit(credit); // 학점

		goldLabel.text = " " + g + gold_unit;
		goldLabel.text = " " + c + credit_unit;
	}

	int CalcGold (int gold)
	{
		GoldRoundDown(gold);

		gold += gold;

		return gold;
	}

	int CalcCredit (int credit)
	{
		return credit;
	}

	int GoldRoundDown (int gold)
	{
		if (gold == 1000)
		{
			gold_unit++;
			return 1;
		}

		return gold;
	}
}
