using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BurgZergArcade.ItemSystem {

	public partial class ISObjectEditor : EditorWindow {
	
		ISWeaponDatabase database;
	
		const string DATABASE_FILE_NAME = @"bzaWeaponDatabase.asset";
		const string DATABASE_PATH_NAME = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH_NAME + "/" + DATABASE_FILE_NAME;
		


		[MenuItem("BZA/Database/Item System Editor %#i")]
		public static void Init() {
			ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
			window.minSize = new Vector2(400, 300);
			window.titleContent.text = "Item System";
			window.Show();
		}

		void OnEnable() {

			if (database == null) {
				database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH_NAME, DATABASE_FILE_NAME);
			} 

		}

		void OnGUI() {
			TopTabBar();

			GUILayout.BeginHorizontal();
			ListView();
			ItemDetails();
			GUILayout.EndHorizontal();

			BottomStatusBar();
		}

	}
}