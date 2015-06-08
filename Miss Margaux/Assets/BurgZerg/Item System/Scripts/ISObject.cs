using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem {

	public class ISObject : IISObject {

		[SerializeField] string _name;
		[SerializeField] int _value;
		[SerializeField] Sprite _icon;
		[SerializeField] int _burden;
		[SerializeField] ISQuality _quality;



		public string Name {
			get {
				return _name;
			}

			set {
				_name = value;
			}
		}



		public int Value {
			get {
				return _value;
			}

			set {
				_value = value;
			}
		}



		public Sprite Icon {
			get {
				return _icon;
			}

			set {
				_icon = value;
			}
		}

		

		public int Burden {
			get {
				return _burden;
			}

			set {
				_burden = value;
			}
		}



		public ISQuality Quality {
			get {
				return _quality;
			}

			set {
				_quality = value;
			}
		}


		/// <summary>
		///  This code is going to be paced in a new class later on.
		/// </summary>

		ISQualityDatabase qdb; 
		int qualitySelectedIndex = 0;
		string[] options;

		public virtual void OnGUI() {
			GUILayout.BeginVertical();

			_name = EditorGUILayout.TextField("Name: ", _name);
			_value = System.Convert.ToInt32(EditorGUILayout.TextField("Value: ", _value.ToString()));
			_burden = System.Convert.ToInt32(EditorGUILayout.TextField("Burden: ", _burden.ToString()));
			DisplayIcon();
			DisplayQuality();

			GUILayout.EndVertical();
		}

		public void DisplayIcon() {
			GUILayout.Label("Icon: ");
		}

		public ISObject() {

			string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
			string DATABASE_PATH_NAME = @"Database";

			qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH_NAME, DATABASE_FILE_NAME);

			options = new string[qdb.Count];
			for (int cnt = 0; cnt < qdb.Count; cnt++) {
				options[cnt] = qdb.Get(cnt).Name;
			}

		}

		public void DisplayQuality() {
			qualitySelectedIndex = EditorGUILayout.Popup("Quality", qualitySelectedIndex, options);
		}
	}
}