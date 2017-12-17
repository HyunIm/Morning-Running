/**
 * @file : GameController.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 게임 컨트롤러 (화폐, 복귀, 장비, 특성, 스킬)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	/// <summary>
	/// 화폐
	/// </summary>
	char gold_unit = 'a';
	int credit_unit = 0;
	int gold = 1;
	int credit = 1;
	int time = 0;

	/// <summary>
	/// 특성
	/// </summary>
	int major = 1;	// 전과하기
	int grade = 1;	// 학년증가
	int name = 1;	// 개명하기

	/// <summary>
	/// 스킬
	/// </summary>
	int cooldown_time = 999;	// 스킬 쿨타임

	/// <summary>
	/// UI
	/// </summary>
	public Text goldLabel;
	public Text creditLabel;


	private void Start()
	{
		goldLabel.text = "" + gold + gold_unit;
		creditLabel.text = " " + credit + credit_unit;
	}

	private void Update()
	{
		time++;
		cooldown_time--;

		if (time == 10)
		{
			gold += major;
			time = 0;
		}
		GoldRoundDown(gold);
		goldLabel.text = "" + gold + gold_unit;
		creditLabel.text = " " + credit;
	}

	/// <summary>
	/// @title : int GoldRoundDown (int gold)
	/// @param : int gold (골드 값)
	/// @return : 1000이 넘을 시 1을 반환, 아닐 시 패스
	/// @brief : 화폐 단위를 잘라주는 함수 (a부터 z까지)
	/// </summary>
	int GoldRoundDown(int gold)
	{
		if (gold >= 1000)
		{
			gold_unit++;
			this.gold = 1;
			return 1;
		}

		return gold;
	}

	/// <summary>
	/// @title : public void ComeBack ()
	/// @brief : 복귀 버튼 (돈 초기화, 학점 증가)
	/// </summary>
	public void ComeBack()
	{
		print("ComeBack");
		// char 'a'(97) 에서 빼줌
		credit_unit = gold_unit - 97;

		this.credit += ((gold + (credit_unit * 1000)) / (1000 - (grade * 10)));

		gold = 0;
		gold_unit = 'a';
	}


	int name_credit = 1000;
	int major_credit = 10;
	int grade_credit = 100;

	public void ReName()
	{
		print("ReName");
		if (credit > name_credit)
		{
			credit -= name_credit;
			name_credit += 1000;
			name++;
		}
	}

	public void ReMajor()
	{
		print("ReMajor");
		if (credit > major_credit)
		{
			credit -= major_credit;
			major_credit += 10;
			major++;
		}
	}

	public void ReGrade()
	{
		print("ReGrade");
		if (credit > grade_credit)
		{
			credit -= grade_credit;
			grade_credit += 10;
			grade++;
		}
	}


	public void Water()
	{
		if (cooldown_time <= 0)
		{
			gold += 1000;
			cooldown_time = 999;
		}
	}

	public void Breath()
	{
		if (cooldown_time <= 0)
		{
			credit += 1000;
			cooldown_time = 999;
		}
	}


}
