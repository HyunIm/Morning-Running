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
	int gold = 1;
	int credit = 1;
	int time = 0;

	/// <summary>
	/// 장비
	/// </summary>
	int bag_level = 1;
	int shoes_level = 1;
	int bag1_price = 10;
	int bag2_price = 20;
	int bag3_price = 30;
	int bag4_price = 40;
	int bag5_price = 50;
	public GameObject PreBag1;
	public GameObject PreBag2;
	public GameObject PreBag3;
	public GameObject PreBag4;
	public GameObject PreBag5;
	public GameObject PostBag1;
	public GameObject PostBag2;
	public GameObject PostBag3;
	public GameObject PostBag4;
	public GameObject PostBag5;
	public GameObject PreShoes1;
	public GameObject PreShoes2;
	public GameObject PreShoes3;
	public GameObject PreShoes4;
	public GameObject PreShoes5;
	public GameObject PostShoes1;
	public GameObject PostShoes2;
	public GameObject PostShoes3;
	public GameObject PostShoes4;
	public GameObject PostShoes5;

	/// <summary>
	/// 특성
	/// </summary>
	int major = 1;	// 전과하기
	int grade = 1;	// 학년증가
	int rname = 1;   // 개명하기
	int name_credit = 1000;
	int major_credit = 10;
	int grade_credit = 100;

	/// <summary>
	/// 스킬
	/// </summary>
	int cooldown_time = 0;	// 스킬 쿨타임

	/// <summary>
	/// UI
	/// </summary>
	public Text goldLabel;
	public Text creditLabel;


	private void Start()
	{
		goldLabel.text = "" + gold;
		creditLabel.text = " " + credit;
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
		goldLabel.text = "" + gold;
		creditLabel.text = " " + credit;
	}


	/// <summary>
	/// @title : public void ComeBack ()
	/// @brief : 복귀 버튼 (돈 초기화, 학점 증가)
	/// </summary>
	public void ComeBack()
	{
		print("ComeBack");

		credit += (gold / (100 - (grade * 10)));
		gold = 1;

		bag_level = 1;
		PreBag1.transform.localPosition = new Vector3(0, 0, 0);
		PreBag2.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag3.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag4.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag5.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag1.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag2.transform.localPosition = new Vector3(0, 0, 0);
		PostBag3.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag4.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag5.transform.localPosition = new Vector3(-20, 0, 0);

		shoes_level = 1;
		PreShoes1.transform.localPosition = new Vector3(0, 0, 0);
		PreShoes2.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes3.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes4.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes5.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes1.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes2.transform.localPosition = new Vector3(0, 0, 0);
		PostShoes3.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes4.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes5.transform.localPosition = new Vector3(-20, 0, 0);
	}


	public void Bag()
	{
		if (bag_level == 1)
		{
			if (gold > bag1_price)
			{
				gold -= bag1_price;
				bag_level++;
				PreBag1.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag2.transform.localPosition = new Vector3(0, 0, 0);
				PostBag2.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag3.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 2)
		{
			if (gold > bag2_price)
			{
				gold -= bag2_price;
				bag_level++;
				PreBag2.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag3.transform.localPosition = new Vector3(0, 0, 0);
				PostBag3.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag4.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 3)
		{
			if (gold > bag3_price)
			{
				gold -= bag3_price;
				bag_level++;
				PreBag3.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag4.transform.localPosition = new Vector3(0, 0, 0);
				PostBag4.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag5.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 4)
		{
			if (gold > bag4_price)
			{
				gold -= bag4_price;
				bag_level++;
				PreBag4.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag5.transform.localPosition = new Vector3(0, 0, 0);
				PostBag5.transform.localPosition = new Vector3(-20, 0, 0);
			}
		}
	}

	public void Shoes()
	{

	}


	public void ReName()
	{
		print("ReName");
		if (credit > name_credit)
		{
			credit -= name_credit;
			rname++;
		}
	}

	public void ReMajor()
	{
		print("ReMajor");
		if (credit > major_credit)
		{
			credit -= major_credit;
			major++;
		}
	}

	public void ReGrade()
	{
		print("ReGrade");
		if (credit > grade_credit)
		{
			credit -= grade_credit;
			grade++;
		}
	}


	public void Water()
	{
		if (cooldown_time <= 0)
		{
			gold += 100;
			cooldown_time = 99 - (rname * 10);
		}
	}

	public void Breath()
	{
		if (cooldown_time <= 0)
		{
			credit += 10;
			cooldown_time = 999 - (rname * 10);
		}
	}


}
