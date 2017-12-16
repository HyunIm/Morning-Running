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
	public char gold_unit = 'a';
	public char credit_unit = 'a';
	public int gold = 1;
	public int credit = 1;

	public Text goldLabel;
	public Text creditLabel;

	private void Update()
	{
		SendMessage("CalcGold");
		SendMessage("CalcCredit");
	}

	public void CalcGold (int gold)
	{
		gold++;

		GoldRoundDown(gold);
		goldLabel.text = " " + gold + gold_unit;
	}

	public void CalcCredit (int credit)
	{
		creditLabel.text = " " + credit + credit_unit;
	}

	int GoldRoundDown (int gold)
	{
		if (gold == 1000)
		{
			gold_unit++;
			return gold - 1000;
		}

		return gold;
	}
}
