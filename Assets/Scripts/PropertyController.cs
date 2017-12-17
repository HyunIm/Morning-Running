/**
 * @file : PropertyCotroller.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 특성 컨트롤러
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyController : MoneyController
{
	int name_credit = 1000;
	int major_credit = 10;
	int grade_credit = 100;

	public void ReName ()
	{
		print("ReName");
		if (credit > name_credit)
		{
			credit -= name_credit;
			name_credit += 1000;
			name++;
		}
	}

	public void ReMajor ()
	{
		print("ReMajor");
		if (credit > major_credit)
		{
			credit -= major_credit;
			major_credit += 10;
			major++;
		}
	}

	public void ReGrade ()
	{
		print("ReGrade");
		if (credit > grade_credit)
		{
			credit -= grade_credit;
			grade_credit += 10;
			grade++;
		}
	}
}
