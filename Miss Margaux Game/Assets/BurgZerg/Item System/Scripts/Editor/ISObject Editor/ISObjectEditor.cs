using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BurgZergArcade.ItemSystem {

	public partial class ISObjectEditor : EditorWindow {

		[MenuItem("BZA/Database/Item System Editor %#i")]
		public static void Init() {
			ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
			window.minSize = new Vector2(400, 300);
			window.title = "Item System";
			window.Show();
		}

		void OnEnable() {


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