using UnityEngine;
using UnityEditor;
using CaptainSly.Generics;

namespace CaptainSly.ItemSystem.Editor
{
	public class ISRarityEditor : EditorWindow
	{
		GenericDatabase<ISRarity> rarityDatabase;
		ISRarity selectedItem;
		Texture2D selectedTexture;

		const int SPRITE_BUTTON_SIZE = 92;

		const string DATABASE_FILE = @"RarityDatabase.asset";
		const string DATABASE_FOLDER_NAME = @"Database";
		const string DATABASE_FULL_PATH = "Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE;

		[MenuItem("DungeonCrawler/Database/Rarity Editor %#i")]
		public static void Init()
		{
			ISRarityEditor window = EditorWindow.GetWindow<ISRarityEditor>();
			window.minSize = new Vector2(400, 300);
			window.titleContent = new GUIContent("Rarity Editor");
			window.Show();
		}

		private void OnEnable()
		{
			if (rarityDatabase == null)
			{

				if (!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME)) 
					AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);

				rarityDatabase = ScriptableObject.CreateInstance<ISRarityDatabase>();

				AssetDatabase.CreateAsset(rarityDatabase, DATABASE_FULL_PATH);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();

			}

			rarityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ISRarityDatabase)) as ISRarityDatabase;
			selectedItem = new ISRarity();
		}

		private void OnGUI()
		{
			AddRarity();
		}

		private void AddRarity()
		{
			// Name
			// Tooltip
			// Color
			// Statboost
			// Sprite

			selectedItem.Name = EditorGUILayout.TextField("Name: ", selectedItem.Name);
			selectedItem.ToolTip = EditorGUILayout.TextField("ToolTip: ", selectedItem.ToolTip);
			selectedItem.StatBoost = EditorGUILayout.DoubleField("StatBoost: ", selectedItem.StatBoost);
			selectedItem.Color = EditorGUILayout.ColorField("Text Color: ", selectedItem.Color);

			if (selectedItem.Icon != null) selectedTexture = selectedItem.Icon.texture;
			else selectedTexture = null;

			if (GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
			{
				int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
				EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
			}

			string commandName = Event.current.commandName;

			if (commandName == "ObjectSelectorUpdated")
			{
				selectedItem.Icon = (Sprite) EditorGUIUtility.GetObjectPickerObject();
				Repaint();
			}

			if (GUILayout.Button("Save"))
			{
				if (selectedItem == null) return;

				rarityDatabase.Add(selectedItem);
				selectedItem = new ISRarity();
			}

		}

	}
}
