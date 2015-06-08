﻿using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem {
	
	public partial class ISObjectEditor {
	
	
		ISWeapon tempWeapon = new ISWeapon();
		bool showNewWeaponDetails = false;

		void ItemDetails() {
			GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

			if (showNewWeaponDetails) {
				DisplayNewWeapon();
			}

			GUILayout.EndVertical();

			GUILayout.Space(50);
			GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
			DisplayButtons();
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
		
		}

		void DisplayNewWeapon() {

			tempWeapon.OnGUI();		
	
		}

		void DisplayButtons() {

			if (!showNewWeaponDetails) {

				if (GUILayout.Button("Create New Weapon")) {
					
					tempWeapon = new ISWeapon();
					showNewWeaponDetails = true; 
				} 

			} else {
				
				if (GUILayout.Button("Save Weapon")) {

					showNewWeaponDetails = false;

//					string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
//					string DATABASE_PATH_NAME = @"Database";
//					ISQualityDatabase qdb; 
//					qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH_NAME, DATABASE_FILE_NAME);
//
//					tempWeapon.Quality = qdb.Get(tempWeapon.SelectedQualityID);

					database.Add(tempWeapon);
					tempWeapon = null;
					
				}
				
				if (GUILayout.Button("Cancel")) {

					showNewWeaponDetails = false;
					tempWeapon = null;
				}
			}
		}
	}

}
