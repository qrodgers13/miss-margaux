using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor {

	public partial class ISQualityDatabaseEditor : EditorWindow {

		ISQualityDatabase qualityDatabase;
		//ISQuality selectedItem;
		Texture2D selectedTexture;
		int selectedIndex = -1;
		Vector2 _scrollPos; // scroll position for list view



		const int SPRITE_BUTTON_SIZE = 46;

		const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
		const string DATABASE_PATH_NAME = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH_NAME + "/" + DATABASE_FILE_NAME;



		[MenuItem("BZA/Database/Quality Editor %#w")]
		public static void Init() {
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
			window.minSize = new Vector2(400, 300);
			window.titleContent.text = "Quality Database";
			window.Show();
		}



		void OnEnable() {

			if (qualityDatabase == null) 
				qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH_NAME, DATABASE_FILE_NAME);

		}
	
	
		void OnGUI() {

			ListView();

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

	
	}

}
