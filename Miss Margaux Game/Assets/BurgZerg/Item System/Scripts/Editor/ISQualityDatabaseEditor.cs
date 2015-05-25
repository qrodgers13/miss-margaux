﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor {

	public partial class ISQualityDatabaseEditor : EditorWindow {

		ISQualityDatabase qualityDatabase;
		ISQuality selectedItem;
		Texture2D selectedTexture;
		int selectedIndex = -1;
		Vector2 _scrollPos; // scroll position for list view



		const int SPRITE_BUTTON_SIZE = 46;

		const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
		const string DATABASE_FOLDER_NAME = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME;



		[MenuItem("BZA/Database/Quality Editor %#i")]
		public static void Init() {
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
			window.minSize = new Vector2(400, 300);
			window.title = "Quality Database";
			window.Show();
		}



		void OnEnable() {

			qualityDatabase = AssetDatabase.LoadAssetAtPath( DATABASE_FULL_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

			if (qualityDatabase == null) {

				if (!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME))
					AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);

				qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
				AssetDatabase.CreateAsset(qualityDatabase, DATABASE_FULL_PATH);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
			}

			selectedItem = new ISQuality();
		}
	
	
		void OnGUI() {

			ListView();
			//AddQualityToDatabase();

			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			BottomBar();
			GUILayout.EndHorizontal();
		}



		void BottomBar() {
			// count
			GUILayout.Label("Qualities: " + qualityDatabase.Count);

			//addbutton
			if (GUILayout.Button("Add")) {
				qualityDatabase.Add(new ISQuality());
			}
		}



//		void AddQualityToDatabase() {
//			//Add name label to editor window 
//			selectedItem.Name = EditorGUILayout.TextField("Name:", selectedItem.Name);
//
//			//Add sprite to editor window
//			if(selectedItem.Icon) {
//				selectedTexture = selectedItem.Icon.texture;
//			} else {
//				selectedTexture = null;
//			}
//
//			if (GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE))) {
//				int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
//				EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
//			}
//
//			string commandName = Event.current.commandName;
//
//			if (commandName == "ObjectSelectorUpdated") {
//				selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
//				Repaint();
//			}
//
//			if (GUILayout.Button("Save")) {
//				if (selectedItem == null)
//					return;
//
//				if (selectedItem.Name == "")
//					return;
//
//				qualityDatabase.Add(selectedItem);
//
//				selectedItem = new ISQuality();
//			}
//		}
	
	}

}
