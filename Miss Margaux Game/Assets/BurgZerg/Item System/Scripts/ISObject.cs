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

		public void DisplayQuality() {
			GUILayout.Label("Quality: ");
		}
	}
}